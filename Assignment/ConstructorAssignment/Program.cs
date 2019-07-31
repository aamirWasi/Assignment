using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Person()
        {
              
        }
        public Person(int id)
        {
            ID = id;
        }
        public Person(int id,string name)
        {
            ID = id;
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1,"aamir");
            Console.WriteLine(person.ID);
            Console.WriteLine(person.Name);
        }
    }
}
