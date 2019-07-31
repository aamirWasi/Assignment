using System.Collections.Generic;

namespace ConstructorAssignment
{
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
}
