using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UnityNetworkingConsole
{
    class Server
    {
        public static int MaxPlayer { get; private set; }
        public static int Port { get; private set; }

        private static TcpListener tcpListener;

        public static void Start(int _maxPlayer, int _port)
        {
            MaxPlayer = _maxPlayer;
            Port = _port;

            tcpListener = new TcpListener(IPAddress.Any, Port);
        }

    }
}
