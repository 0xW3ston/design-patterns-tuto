using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Strategy
{
    public class FedExShipping : IShippingStrategy
    {
        public decimal CalculateShippingCost(double weight, double distance)
        {
            return (decimal)(weight * distance);
        }

        public bool startShipping()
        {
            // Start Shipping
            return true;
        }
    }

    public class UPSShipping : IShippingStrategy
    {
        public decimal CalculateShippingCost(double weight, double distance)
        {
            return (decimal)(weight * distance) + 10;
        }

        public bool startShipping()
        {
            // Start Shipping
            return true;
        }
    }

    public class DHLShipping : IShippingStrategy
    {
        public decimal CalculateShippingCost(double weight, double distance)
        {
            return (decimal)(weight * distance) + 50;
        }

        public bool startShipping()
        {
            // Start Shipping
            return true;
        }
    }
}
