using System;
namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Product = "Laptop",
                Quantity = 120,
                Price = 899.99
            };

            OrderProcessor orderProcessor = new OrderProcessor(order);
            orderProcessor.ProcessOrder();
            orderProcessor.ShipOrder();
        }
    }
}
