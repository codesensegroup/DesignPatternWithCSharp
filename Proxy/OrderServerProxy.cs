using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class OrderServerProxy : IOrderServer
    {
        private string Order;
        private IOrderServer _server = new OrderServer();

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }

        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
            Order = order;
        }
    }
}
