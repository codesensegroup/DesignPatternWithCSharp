using System;

namespace Singleton
{
    public class PrintrWithNoSingleton
    {
 
        public PrintrWithNoSingleton()
        {
        }

        public void PrinterDetail(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
