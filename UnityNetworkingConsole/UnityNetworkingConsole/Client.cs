using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UnityNetworkingConsole
{
    class Client
    {
        public static int dataBufferSize = 
        public int id;
        public TCP tcp;

        public class TCP
        {
            public TcpClient socket;

            private readonly int id;

            public TCP(int _id)
            {
                id = _id;
            }

            public void Connect(TcpClient _socket)
            {
                socket = _socket;
                socket.ReceiveBufferSize = databuf
            }
        }
    }
}
