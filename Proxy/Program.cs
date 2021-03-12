using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderServer orderService = new OrderServerProxy();
            orderService.TakeOrder("Cell Phone");
            orderService.ProcessPayment(orderService.DeliverOrder());

        

        }
    }
}
