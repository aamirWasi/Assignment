using System;
namespace IterationStatement
{
    public class BreakContinueStatement
    {
        static void Main()
        {
            var passwordLength = 10;
            var random = new Random();
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                buffer[i]=(char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);
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
