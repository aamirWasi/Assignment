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
            //Guessing Number game with While statement starts

            Console.WriteLine("I want you to think of a number between 0 to 100.Ok?");
            Console.ReadLine();
            int max = 100;
            int guesses = 0;
            int guessMin = 0;
            int guessMax = max / 2;

            while (guessMin != max)
            {
                guesses++;
                Console.WriteLine($"Is your number is between {guessMin} to {guessMax} ? Y/N");
                var response = Console.ReadLine();
                if (response?.ToLower().FirstOrDefault() == 'y')
                {
                    max = guessMax;//50
                    guessMax -= (guessMax - guessMin) / 2;//25
                }
                else
                {
                    guessMin = guessMax + 1;//51
                    var reminingDifference = max - guessMax;//50
                    guessMax += (int)Math.Ceiling(reminingDifference / 2f);//75
                }
                if (guessMin + 1 == max)
                {
                    guesses++;
                    Console.WriteLine($"Is your number is {guessMin}");
                    response = Console.ReadLine();
                    if (response?.ToLower().FirstOrDefault() == 'y')
                        break;
                    else
                    {
                        guessMin = max;
                        break;
                    }
                }
            }
            Console.WriteLine($"** Your number is {guessMin} **");

            Console.WriteLine($"Guessed in {guesses} times");


            //Guessing Number game with While statement ends
            for (int i = 1; i < 10; i++)
            {
                //PrintEvenNumber(i);
            }
            //reverse order 
            for (int i = 10; i>=1; i--)
            {
                //PrintEvenNumber(i);
            }
        }
        static void PrintEvenNumber(int i)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
