namespace Proxy.AOP
{
    public class RealCalculate : ICalculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
