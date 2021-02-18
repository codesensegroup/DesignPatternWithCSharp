using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class PrinterSingletonHolder
    {

        public static class SingletonHolder
        {
            static SingletonHolder() { }
            internal static readonly PrinterSingletonHolder INSTANCE = new PrinterSingletonHolder();
        }
        public static PrinterSingletonHolder Instance { get { return SingletonHolder.INSTANCE; } }

        public void PrinterDetail(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
