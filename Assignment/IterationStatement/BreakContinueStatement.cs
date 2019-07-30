using System;
namespace IterationStatement
{
    public class BreakContinueStatement
    {
        static void Main()
        {
            //Continue statement
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }

            //Break statement
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
        }
        //static void PrintEvenNumber(int i)
        //{
        //    if (i % 2 == 0)
        //        continue;
        //}
    }
}
