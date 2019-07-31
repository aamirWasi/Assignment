using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    public class Person
    {
        public DateTime BirthDate { get; private set; }
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
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
            var person = new Person(new DateTime(1996, 2, 3));
            Console.WriteLine(person.Age);
        }
    }
}
