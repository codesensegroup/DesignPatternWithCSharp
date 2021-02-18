using System;
using System.Security.Policy;

namespace Factory
{
    public class HTTPConn : IConnection
    {
        private Url url;

        public HTTPConn(Url url)
        {
            this.url = url;
        }

        public void open()
        {
            Console.WriteLine(" Open url with browser");
        }
    }
}
