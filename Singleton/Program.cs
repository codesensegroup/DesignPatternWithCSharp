using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Demo no singleton");
            var p1 = new PrintrWithNoSingleton();
            p1.PrinterDetail("HashCode:"+p1.GetHashCode().ToString());
            var p2 = new PrintrWithNoSingleton();
            p2.PrinterDetail("HashCode:" + p2.GetHashCode().ToString());

            Console.WriteLine("Demo with singleton");
            var sp1 = PrinterSingletonHolder.Instance;
            sp1.PrinterDetail("HashCode:" + sp1.GetHashCode().ToString());
            var sp2 = PrinterSingletonHolder.Instance;
            sp1.PrinterDetail("HashCode:" + sp1.GetHashCode().ToString());
        }
    }
}
