using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatement
{
    
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                PrintEvenNumber(i);
            }
            //reverse order 
            for (int i = 10; i>=1; i--)
            {
                PrintEvenNumber(i);
            }
        }
        static void PrintEvenNumber(int i)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
