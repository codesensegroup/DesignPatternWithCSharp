using Grpc.Core;
using System;

namespace Factory
{
    public class SSHConn : IConnection
    {
        private Server _destServer;

        public SSHConn(Server destServer)
        {
            this._destServer = destServer;
        }

        public void open()
        {
            Console.WriteLine("Open a terminal and ssh into the destination server");
        }
    }
}
