using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicAssignment
{
    public class GenericDynamic
    {
        public void Add<T>(T a,T b)
        {
            //var sum = a + b;//shows error
            //Opeartor can not be applied of Type of T and T
            //so use dynamic that's allow datatype of the variable is identified in the runtime
            dynamic x = a;
            dynamic y = b;
            var sum = x + y;
            Console.WriteLine($"Summation is {sum}");
        }
    }
    public class Generic2<T>
    {
        public void Add(T a, T b)
        {
            //var sum = a + b;//shows error
            //Opeartor can not be applied of Type of T and T
            //so use dynamic that's allow datatype of the variable is identified in the runtime
            dynamic x = a;
            dynamic y = b;
            var sum = x + y;
            Console.WriteLine($"Summation is {sum}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new GenericDynamic();
            obj.Add<int>(10, 20);


            var obj2 = new Generic2<int>();
            obj2.Add(20, 30);

        }
    }
}
