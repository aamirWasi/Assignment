using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFElseAssignment
{

    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            
            while (!exit)
            {
                Console.WriteLine("Enter an hour between 1 to 24");
                Console.WriteLine("Press 0 for exit.");
                int hour = int.Parse(Console.ReadLine());
                if (hour == 0)
                    exit = true;
                else
                {
                    if (hour > 0 && hour < 12)
                        Console.WriteLine($"{hour}am.it's morning.");
                    else if (hour >= 12 && hour < 6)
                        Console.WriteLine($"{hour - 12}pm.it's afternoon.");
                    else
                        Console.WriteLine($"{hour - 12}pm.it's evening.");
                }

                //Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' for menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
