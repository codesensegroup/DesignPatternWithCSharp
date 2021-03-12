using System;

namespace Proxy.AOP
{
    public class ProxyCalculate : ICalculate
    {
        private readonly ICalculate _calculate;

        public ProxyCalculate(ICalculate calculate)
        {
            this._calculate = calculate;
        }

        public int Add(int x, int y)
        {
            Console.WriteLine("呼叫時間 " + DateTime.Now);
            Console.WriteLine("傳入 x = " + x);
            Console.WriteLine("傳入 y = " + y);

            if (x <= 0)
            {
                Console.WriteLine("x 必須大於 1");
                return -1;
            }

            if (y <= 0)
            {
                Console.WriteLine("y 必須大於 1");
                return -1;
            }

            if (y > 100)
            {
                Console.WriteLine("y 最大值為 100");
                return -1;
            }

            var result = this._calculate.Add(x, y);

            Console.WriteLine("執行結果 " + result);

            return result;
        }
    }
}
