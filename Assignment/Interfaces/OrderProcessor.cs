using System;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("The order is already is processed...");
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShippingCost(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
            var totalCost = order.TotalPrice + order.Shipment.Cost;
            Console.WriteLine($"Total price + shipping : {totalCost}");
        }
    }
}
