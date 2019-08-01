using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var something1 = "Something";
            var something2 = "Something";
            if (something1.Equals(something2, StringComparison.CurrentCulture))
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Both are not same");
            }
        }
    }
}
