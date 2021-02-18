using Grpc.Core;
using System.Security.Policy;

namespace Factory
{
    public class ConnectionFactory
    {
        public IConnection CreateConnection(object link)
        {
            if(link is Url)
            {
                return new HTTPConn(link as Url);
            }

            return new SSHConn(link as Server);
        }

    }
}
