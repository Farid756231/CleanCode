using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Order
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        private const double DiscountThresholdHigh = 100;
        private const double DiscountThresholdMedium = 50;
        private const double HighDiscountRate = 0.10;
        private const double MediumDiscountRate = 0.05;

        public double CalculateTotal()
        {
            ValidateOrder();
            double discount = CalculateDiscount();
            return (Price * Quantity) - discount;
        }

        private void ValidateOrder()
        {
            if (Quantity <= 0 || string.IsNullOrEmpty(Product))
            {
                throw new InvalidOrderException("Invalid order! Product or quantity is not properly defined.");
            }
        }

        private double CalculateDiscount()
        {
            if (Quantity > DiscountThresholdHigh)
            {
                return Price * Quantity * HighDiscountRate;
            }
            else if (Quantity > DiscountThresholdMedium)
            {
                return Price * Quantity * MediumDiscountRate;
            }
            return 0;
        }
    }
}
