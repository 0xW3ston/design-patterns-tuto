using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Strategy
{
    public class ShippingService
    {
        private IShippingStrategy _shippingStrat;
        private double _weight;

        public ShippingService(double weight, IShippingStrategy? strategy = null) {
            _weight = weight;
            if (strategy == null)
                _shippingStrat = new FedExShipping();
            else
                _shippingStrat = strategy;
        }

        public void SetShippingStrategy(IShippingStrategy shippingStrat)
        {
            _shippingStrat = shippingStrat;
        }

        public double GetWeight() {
            return _weight;
        }

        public decimal CalculateShippingCosts(double distance)
        {
            return _shippingStrat.CalculateShippingCost(this._weight, distance);
        }
    }
}
