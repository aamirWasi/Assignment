using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierAssignment
{
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("Private method...");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal method...");

        }
        protected void Test3()
        {
            Console.WriteLine("protected method...");

        }
        protected internal void Test4()
        {
            Console.WriteLine("protected internal method...");

        }
        public void Test5()
        {
            Console.WriteLine("Public method...");
        }
        static void Main(string[] args)
        {
            var program = new Program();
            program.Test1();
            program.Test2();
            program.Test3();
            program.Test4();
            program.Test5();
        }
    }
}
