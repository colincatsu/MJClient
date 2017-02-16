using UnityEngine;
using System;
using System.IO;
using System.Net.Sockets;
using MX;
using XLua;

namespace MX
{
    [LuaCallCSharp]
    public class SocketClient
    {
        private TcpClient _client = null;
        private NetworkStream _network_stream = null;
        private MemoryStream _memory_steam = null;
        private BinaryReader _binary_reader = null;

        private const int MAX_READ = 8192;
        private byte[] _bytes = new byte[MAX_READ];
        public static bool _logged = false;

        public SocketClient() { }

        public void OnRegister()
        {
            _memory_steam = new MemoryStream();
            _binary_reader = new BinaryReader(_memory_steam);
        }

        //移除代理
        public void OnRemove()
        {
            this.Close();
            _binary_reader.Close();
            _memory_steam.Close();
        }

        //连接服务器
        void ConnectServer(string host, int port)
        {
            _client = new TcpClient();
            _client.SendTimeout = 3000;
            _client.ReceiveTimeout = 3000;
            _client.NoDelay = true;
            try
            {
                Debug.Log("Connet Server:" + host + " port:" + port);
                _client.BeginConnect(host, port, new AsyncCallback(OnConnect), null);
            }
            catch (Exception e)
            {
                this.Close();
                Debug.LogError(e.Message);
            }
        }

        //连接上服务器
        void OnConnect(IAsyncResult asr)
        {
            _network_stream = _client.GetStream();
            _client.GetStream().BeginRead(_bytes, 0, MAX_READ, new AsyncCallback(OnRead), null);

            const string command = @"
                Network = require 'Network'
                Network.OnConnet()
            ";
            LuaEnvSingleton.Instance.DoString(command);
        }

        //写数据
        void WriteMessage(byte[] message)
        {
            MemoryStream ms = new MemoryStream();
            ms.Position = 0;
            BinaryWriter writer = new BinaryWriter(ms);
            writer.Write(message);
            writer.Flush();
            if (_client != null && _client.Connected)
            {
                byte[] payload = ms.ToArray();
                _network_stream.BeginWrite(payload, 0, payload.Length, new AsyncCallback(OnWrite), null);
            }
            else
            {
                Debug.LogError("WriteMessage--->>>Socket has been closed.");
            }
        }

        //发送数据回调
        void OnSend(IAsyncResult r)
        {
            try
            {
                _network_stream.EndWrite(r);
            }
            catch (Exception ex)
            {
                Debug.LogError("OnSend--->>>" + ex.Message);
            }
        }

        //读取消息
        void OnRead(IAsyncResult asr)
        {
            Debug.LogWarning("OnRead--->>>");

            int bytes_readed = 0;
            try
            {
                lock (_client.GetStream())
                {
                    bytes_readed = _client.GetStream().EndRead(asr);
                }

                Debug.LogWarning("OnRead--->>>" + bytes_readed);

                if (bytes_readed < 1)
                {
                    OnDisconnected("bytes_readed < 1");
                    return;
                }
                OnReceive(_bytes, bytes_readed);
                lock (_client.GetStream())
                {
                    Array.Clear(_bytes, 0, _bytes.Length);
                    _client.GetStream().BeginRead(_bytes, 0, MAX_READ, new AsyncCallback(OnRead), null);
                }
            }
            catch (Exception ex)
            {
                OnDisconnected(ex.Message);
            }
        }

        //丢失服务器连接
        void OnDisconnected(string msg)
        {
            this.Close();
            Debug.LogError("OnDisconnected--->>>" + msg);
            const string command = @"
                Network = require 'Network'
                Network.OnDisconnect()
            ";
            LuaEnvSingleton.Instance.DoString(command);
        }

        //发送数据回调
        void OnWrite(IAsyncResult r)
        {
            try
            {
                _network_stream.EndWrite(r);
            }
            catch (Exception ex)
            {
                Debug.LogError("OnWrite--->>>" + ex.Message);
            }
        }

        //接收到服务器数据
        void OnReceive(byte[] bytes, int length)
        {
            _memory_steam.Seek(0, SeekOrigin.End);
            _memory_steam.Write(bytes, 0, length);
            _memory_steam.Seek(0, SeekOrigin.Begin);
            while (RemainingBytes() > 0)
            {
                if (RemainingBytes() >= length)
                {
                    MemoryStream ms = new MemoryStream();
                    BinaryWriter writer = new BinaryWriter(ms);
                    writer.Write(length);
                    writer.Write(_binary_reader.ReadBytes(length));
                    ms.Seek(0, SeekOrigin.Begin);
                    OnReceivedMessage(ms);
                }
                else
                {
                    break;
                }
            }

            byte[] leftover = _binary_reader.ReadBytes((int)RemainingBytes());
            _memory_steam.SetLength(0);     //Clear
            _memory_steam.Write(leftover, 0, leftover.Length);
        }

        //剩余的字节
        private long RemainingBytes()
        {
            return _memory_steam.Length - _memory_steam.Position;
        }

        [CSharpCallLua]
        public delegate int FDelegate(ByteBuffer buffer);
        //接收到消息
        void OnReceivedMessage(MemoryStream ms)
        {
            Debug.LogError("接收到数据--->>>");

            BinaryReader r = new BinaryReader(ms);
            byte[] message = r.ReadBytes((int)(ms.Length - ms.Position));
            ByteBuffer buffer = new ByteBuffer(message);

            const string command = @"
                Network = require 'Network'
            ";
            LuaEnvSingleton.Instance.DoString(command);
            FDelegate func = LuaEnvSingleton.Instance.Global.Get<FDelegate>("Network.OnReceived");
            func(buffer);
        }

        //会话发送
        void SessionSend(byte[] bytes)
        {
            WriteMessage(bytes);
        }

        //关闭链接
        public void Close()
        {
            Debug.LogWarning("Close Socket--->>>");
            if (_client != null)
            {
                if (_client.Connected) _client.Close();
                _client = null;
            }
            _logged = false;

            const string command = @"
                Network = require 'Network'
                Network.OnClose()
            ";
            LuaEnvSingleton.Instance.DoString(command);
        }

        //发送连接请求
        public void SendConnect()
        {
            //ConnectServer("10.236.100.114", 50000);
            ConnectServer("182.92.87.147",50000);

        }

        //发送消息
        public void SendMessage(ByteBuffer buffer)
        {
            SessionSend(buffer.ToBytes());
            buffer.Close();
        }

        public void SendProtocol(string meta)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(meta);
            SessionSend(bytes);
        }
    }
}