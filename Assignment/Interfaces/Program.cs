using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                TotalPrice = 20f,
                DatePlaced = DateTime.Now
            };
            var orderProcssor = new OrderProcessor(new ShippingCalculator());
            orderProcssor.Process(order);
            var user = new User
            {
                Status = RegistrationStatus.Active,
                Type=UserType.Admin
            };
            if (user.Type==UserType.Admin && user.Status==RegistrationStatus.Active)
                Console.WriteLine("Login Successfull...");
        }
    }
}
