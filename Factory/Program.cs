using System.Security.Policy;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = new Url("http://www.example.com/test.xml");
            var connFactory = new ConnectionFactory();
            var conn = connFactory.CreateConnection(url);
            conn.open();
        }
    }
}
