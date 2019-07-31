using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    public class Person
    {
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                return timeSpan.Days/365;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                BirthDate = new DateTime(1996, 2, 3)
            };
            Console.WriteLine(person.Age);
        }
    }
}
