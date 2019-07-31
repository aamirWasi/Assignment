using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1996, 2, 3),Cities.chittagong,true);
            Console.WriteLine(person.Age);
            if(person.Status==true)
                Console.WriteLine("Customer status : Active");
            else
                Console.WriteLine("Customer status : In-Active");
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Current city is : {person.City}");
            person.City = Cities.Rajshahi;
            Console.WriteLine($"Modified city is : {person.City}");
            Console.WriteLine($"Country name is : {person.Country}");

        }
    }
}
