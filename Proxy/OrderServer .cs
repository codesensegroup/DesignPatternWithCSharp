using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class OrderServer : IOrderServer
    {
        private string Order;

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }

        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            Order = order;
        }
    }
}
