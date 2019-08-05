using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP13Banglawash
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            double t1, t2, sumBangla=0, sumPak = 0, t3, t4, pakTotal = 0, banglaTotal = 0;
            for (int i = 0; i < T; i++)
            {
                sumBangla = 0;
                pakTotal = 0;
                sumPak = 0;
                banglaTotal = 0;
                for (int j = 0; j < 2; j++)
                {
                    string line = Console.ReadLine();
                    string[] arr = line.Split(' ');
                    t1 = double.Parse(arr[0]);
                    t2 = double.Parse(arr[1]);
                    t3 = double.Parse(arr[2]);
                    t4 = double.Parse(arr[3]);
                    sumBangla = t1 + t2;
                    sumPak = t3 + t4;
                    //Console.WriteLine(sumBangla);
                    //Console.WriteLine(sumPak);
                }
                pakTotal += sumPak;
                banglaTotal += sumBangla;
                Console.WriteLine(banglaTotal);
                Console.WriteLine(pakTotal);
                if (banglaTotal <= pakTotal /*|| banglaTotal == pakTotal*/)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Banglawash");
                }
            }
        }
    }
}
