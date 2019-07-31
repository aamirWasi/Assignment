using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAssignment
{
    public enum Cities
    {
        dhaka=1,
        chittagong=2,
        Rajshahi=3,
        Barisal=4,
        Shylet=5,
        Jessor=6
    }
    public class Person
    {
        private readonly Cities _city;

        public DateTime BirthDate { get; private set; }
        public Person(DateTime birthDate,Cities city)
        {
            BirthDate = birthDate;
            _city = city;
        }
        public Cities City
        {
            get
            {
                return _city;
            }
            //set
            //{
            //    value = _city;
            //}
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
            var person = new Person(new DateTime(1996, 2, 3),Cities.chittagong);
            Console.WriteLine(person.Age);
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Current city is : {person.City}");

        }
    }
}
