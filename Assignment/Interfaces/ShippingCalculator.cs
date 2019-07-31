namespace Interfaces
{
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShippingCost(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}
