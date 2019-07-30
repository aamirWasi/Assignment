using System;
namespace IterationStatement
{
    public class WhileStatement
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter your name ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine($"My Name is : {input}");
            }
        }
    }
}
