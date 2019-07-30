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
            var user = new User();
            if( user.Status==RegistrationStatus.Active && 
                user.Type == UserType.Admin)
            {
                Console.WriteLine("Login in successfully...");
            }
        }
    }
}
