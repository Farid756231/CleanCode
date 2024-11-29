using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class OrderProcessor
    {

        private readonly Order _order;

        public OrderProcessor(Order order)
        {
            _order = order;
        }
        public void ProcessOrder()
        {
            try
            {
                double total = _order.CalculateTotal();
                Console.WriteLine($"Processing order for {_order.Quantity} {_order.Product}(s) at ${_order.Price * _order.Quantity}");
                Console.WriteLine($"Total price: ${total}");
            }
            catch (InvalidOrderException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order shipped");
        }
    }
}
