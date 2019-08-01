using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Person
            {
                FirstName = "aamir",
                LastName = "wasi"
            };
            if (user.FirstName == user.LastName)
            {
                Console.WriteLine("Both strings are same");
            }
            else
            {
                Console.WriteLine("Both are not same");
            }
        }
    }
}
