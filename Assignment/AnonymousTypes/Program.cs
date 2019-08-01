using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    public delegate string GreetingDelegate(string name);
    class Program
    {
        static string Greetings(string name)
        {
            return $"Hello {name} a very good morning...";
        }
        static void Main(string[] args)
        {
            var obj = new GreetingDelegate(Greetings);
            Console.WriteLine(obj("aamir"));
        }
    }
}
