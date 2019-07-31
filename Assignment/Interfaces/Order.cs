using System;

namespace Interfaces
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public int ID { get; set; }
        public Shipment Shipment { get; set; }
        public DateTime DatePlaced { get; set; }
        public bool IsShipped
        {
            get
            {
                return Shipment != null;
            }
        }
    }
}
