﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using XLua;

namespace MX
{
    [LuaCallCSharp]
    public enum Protocal
    {
        Connect         = 1,	//连接服务器
        Exception,	            //异常掉线
        Disconnect,             //正常断线  
        Timeout,
        Ping,
        Receive,
    }

    [LuaCallCSharp]
    public class NetworkManager : MonoBehaviour {

        private static NetworkManager _instance = null;
        public static NetworkManager Instance
        {
            get {
                if(null == _instance)
                {
                    GameObject go = new GameObject("NetworkManager");
                    _instance = go.AddComponent<NetworkManager>();
                }
                return _instance;
            }
        }
        public void TouchInstance()
        {  }

        private object lockobj = new object();
        private Queue<KeyValuePair<Protocal, ByteBuffer>> sEvents = new Queue<KeyValuePair<Protocal, ByteBuffer>>();

        private SuperSocket.ClientEngine.SuperSocketClient m_SuperSocket;
        public SuperSocket.ClientEngine.SuperSocketClient LogicSocket
        {
            get {
                if (m_SuperSocket == null)
                {
                    m_SuperSocket = new SuperSocket.ClientEngine.SuperSocketClient(this);
                }
                return m_SuperSocket;
            }
        }

        void Awake() {
            DontDestroyOnLoad(gameObject);
        }

        void OnDestroy()
        {
            LogicSocket.Close();
        }

        
        public void AddEvent(Protocal id, ByteBuffer data)
        {
            lock(lockobj)
            {
                sEvents.Enqueue(new KeyValuePair<Protocal, ByteBuffer>(id, data));
            }
        }
        [CSharpCallLua]
        public delegate int FDelegate(Protocal protocal, ByteBuffer buffer);
        FDelegate func = null;
        protected void CallMethod(Protocal protocal, ByteBuffer buffer)
        {
            if (func == null)
            {
                func = LuaEnvSingleton.Instance.Global.GetInPath<FDelegate>("Network.OnReceiveMessageQueue");
            }
            func(protocal,buffer);
        }

        /// <summary>
        /// 交给Command，这里不想关心发给谁。
        /// </summary>
        void Update()
        {
            lock (lockobj)
            {
                if (sEvents.Count > 0)
                {
                    while (sEvents.Count > 0)
                    {
                        KeyValuePair<Protocal, ByteBuffer> _event = sEvents.Dequeue();
                        CallMethod(_event.Key, _event.Value);
                    }
                }
            }
        }


        public void ConnectTo(string host, int port)
        {
            LogicSocket.ConnectTo(host, port);
        }

        public void Close()
        {
            LogicSocket.Close();
        }

		public int SendMessage(byte[] buffer)
        {
            return LogicSocket.Send(buffer);
        }

        public bool IsConnected
        {
            get
            {
                return LogicSocket.IsConnected;
            }
        }

        public void Ping(string ip)
        {
            new System.Threading.Thread(() =>
            {
                try
                {
                    System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                    string data = "Hello!";
                    byte[] buffer = System.Text.Encoding.ASCII.GetBytes(data);
                    int timeout = 1000; // Timeout 时间，单位：毫秒  
                    p.PingCompleted += new System.Net.NetworkInformation.PingCompletedEventHandler((object sender, System.Net.NetworkInformation.PingCompletedEventArgs e) =>
                    {
                        try
                        {
                            if(e.Error != null)
                            {
                                ByteBuffer buffer2 = new ByteBuffer();
                                buffer2.WriteString(string.Format("Ping:{0},Error:{1}", ip,e.Error.Message));
                                AddEvent(Protocal.Ping, new ByteBuffer(buffer2.ToBytes()));
                            }
                            System.Net.NetworkInformation.PingReply reply = e.Reply;
                            if (reply != null && reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                            {
                                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                                sb.AppendFormat("AcceptHost:{0}\n", reply.Address.ToString());
                                sb.AppendFormat("RoundTime:{0}\n", reply.RoundtripTime);
                                sb.AppendFormat("TTL:{0}", reply.Options.Ttl);
                                sb.AppendFormat("DontFragment:{0}", reply.Options.DontFragment);
                                sb.AppendFormat("Length:{0}", reply.Buffer.Length);
                                ByteBuffer buffer2 = new ByteBuffer();
                                buffer2.WriteString(sb.ToString());
                                AddEvent(Protocal.Ping, new ByteBuffer(buffer2.ToBytes()));
                            }
                            else
                            {
                                ByteBuffer buffer2 = new ByteBuffer();
                                buffer2.WriteString(string.Format("Ping:{0},Cannot Reachable", ip));
                                AddEvent(Protocal.Ping, new ByteBuffer(buffer2.ToBytes()));
                            }
                        }
                        catch (Exception ex)
                        {
                            ByteBuffer buffer2 = new ByteBuffer();
                            buffer2.WriteString(string.Format("Ping:{0},Error:{1}", ip, ex.Message));
                            AddEvent(Protocal.Ping, new ByteBuffer(buffer2.ToBytes()));
                        }
                    });
                    p.SendAsync(ip, timeout, buffer, null);
                }
                catch (Exception ex)
                {
                    ByteBuffer buffer2 = new ByteBuffer();
                    buffer2.WriteString(string.Format("Ping:{0},Error:{1}", ip, ex.Message));
                    AddEvent(Protocal.Ping, new ByteBuffer(buffer2.ToBytes()));
                }
            }).Start();
        }

    }
}