using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Order
    {

    }
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Order> Orders;
        public Person()
        {
            Orders = new List<Order>();
        }
        public Person(int id)
            :this()
        {
            ID = id;
        }
        public Person(int id,string name)
            :this(id)
        {
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
