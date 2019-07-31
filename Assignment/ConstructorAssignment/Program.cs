using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
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
