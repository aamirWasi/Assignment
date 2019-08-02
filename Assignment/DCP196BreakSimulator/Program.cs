using System;
namespace DCP196BreakSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            double v, t, de;
            for (int i = 0; i < T; i++)
            {
                string line = Console.ReadLine();
                string[] arr = line.Split(' ');
                v = double.Parse(arr[0]);
                t = double.Parse(arr[1]);
                de = -(v / t);
                Console.WriteLine($"{de:F2}");
            }
        }
    }
}
