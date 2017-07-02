using UnityEngine;
using System.Collections;
using SuperSocket.ProtoBase;
using System;
using System.IO;
using MX;

namespace SuperSocket.ClientEngine
{
    public class SuperSocketClient : EasyClient
    {
        const int HeadSize = 2;
        NetworkManager NetMgr;
        public SuperSocketClient(NetworkManager mgr)
        {
            NetMgr = mgr;
            this.Initialize<FPackageInfo>(new FReceiveFilter(), HandlePackage);
            this.Connected += new EventHandler(onConnect);
            this.Closed += new EventHandler(onClosed);
            this.Error += new EventHandler<ErrorEventArgs>(onError);
        }

        public void ConnectTo(string ip, int port)
        {
            this.BeginConnect(new System.Net.IPEndPoint(System.Net.IPAddress.Parse(ip), port));
        }

        public int Send(byte[] buffer)
        {
            //MemoryStream ms = null;
            //using (ms = new MemoryStream())
            //{
            //    ms.Position = 0;
            //    BinaryWriter writer = new BinaryWriter(ms);
            //    ushort msglen = (ushort)buffer.Length;
            //    writer.Write(msglen);
            //    writer.Write(buffer);
            //    writer.Flush();
            //    byte[] payload = ms.ToArray();
            //    return Send(payload, 0, payload.Length);
            //}
            return Send(buffer, 0, buffer.Length);
            //ushort body_size = (ushort)buffer.Length;
            //byte[] headBytes = new byte[HeadSize];
            //headBytes[0] = (byte)(body_size & 0xff >> 8);
            //headBytes[1] = (byte)(body_size & 0xff);
            //byte[] newBuffer = new byte[buffer.Length + HeadSize];
            //headBytes.CopyTo(newBuffer, 0);
            //buffer.CopyTo(newBuffer, HeadSize);
            //return Send(newBuffer, 0, newBuffer.Length);
        }

        protected int Send(byte[] buffer, int offset, int length)
        {
            Send(new ArraySegment<byte>(buffer, 0, length));
            return length;
        }

        void onConnect(object sender, EventArgs arg)
        {
            if (null != NetMgr) NetMgr.AddEvent(Protocal.Connect, new ByteBuffer());
        }

        void onClosed(object sender, EventArgs arg)
        {
            if (null != NetMgr)
            {
                ByteBuffer buffer = new ByteBuffer();
                buffer.WriteString("Socket Link Is Broken!");
                NetMgr.AddEvent(Protocal.Disconnect, new ByteBuffer(buffer.ToBytes()));
            }
            else
                Debug.LogWarning("Socket Link Is Broken!");
        }

        void onError(object sender, ErrorEventArgs e)
        {
            if (null != NetMgr)
            {
                ByteBuffer buffer = new ByteBuffer();
                buffer.WriteString(e.Exception.Message);
                NetMgr.AddEvent(Protocal.Exception, new ByteBuffer(buffer.ToBytes()));
            }
            Debug.LogWarning("Socket Error:" + e.Exception.Message);
        }

        void onReceived(object sender, byte[] data)
        {
            if (null != NetMgr)
            {
                //for (int i = 0; i < data.Length; i++)
                //    Debug.LogWarning("data----" + data[i]);
                ByteBuffer buffer = new ByteBuffer(data);
                NetMgr.AddEvent(Protocal.Receive, buffer);
            }
            else
                Debug.Log("onReceive:{0}");
        }
        void HandlePackage(FPackageInfo package)
        {
            //if(package.Body != null)
            onReceived(this, package.Body);
        }

        /// <summary>
        /// FPackageInfo
        /// </summary>
        class FPackageInfo : IPackageInfo
        {
            public byte[] Body { get; protected set; }

            public FPackageInfo(byte[] body)
            {
                Body = body;
            }
        }
        /// <summary>
        /// FReceiveFilter
        /// </summary>
        class FReceiveFilter : FixedHeaderReceiveFilter<FPackageInfo>
        {
            //const int H_SIZE = sizeof(int);
            const int H_SIZE = 2;
            public FReceiveFilter() : base(H_SIZE) { }
            public override FPackageInfo ResolvePackage(IBufferStream bufferStream)
            {
                var PackageTogalSize = (int)(bufferStream.Length);
                bufferStream.Skip(H_SIZE);

                byte[] data = new byte[PackageTogalSize - H_SIZE];
                bufferStream.Read(data, 0, PackageTogalSize - H_SIZE);
                
                return new FPackageInfo(data);
            }

            protected override int GetBodyLengthFromHeader(IBufferStream bufferStream, int length)
            {
                byte[] lenbuffer = new byte[length];
                bufferStream.Read(lenbuffer, 0, length);
                int nLen = (int)lenbuffer[0] * 256 + (int)lenbuffer[1];
                //BitConverter.ToInt16(lenbuffer, 0);
                //Debug.LogWarning("length---------" + nLen);
                return nLen;
            }
        }
    }

#if TEST_EASYSOCKET
    public class FTestSuperSocket : FSuperSocket
    {
        public FTestSuperSocket() : base(null) {

            this.Connected += new EventHandler(OnConnectSuccess);
        }

        void OnConnectSuccess(object sender, EventArgs arg)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.BinaryWriter writer = new System.IO.BinaryWriter(ms);
            writer.Write((short)2);
            writer.Write("Hello");

            Send(new ArraySegment<byte>(ms.ToArray()));
        }
    }
#endif
}
