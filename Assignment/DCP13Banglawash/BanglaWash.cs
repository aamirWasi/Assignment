using System;
namespace DCP13Banglawash
{
    public class BanglaWash
    {
        static void Main()
        {
            int sumBan, sumPak, banFirst, banSecond, pakFirst, pakSecond;
            int banFirst2, banSecond2, sumBan2;
            int pakFirst2, pakSecond2, sumPak2;
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                sumBan = 0; sumPak = 0;
                sumBan2 = 0; sumPak2 = 0;
                for (int i = 0; i < 1; i++)
                {
                    string line = Console.ReadLine();
                    string line2 = Console.ReadLine();
                    string[] arr = line.Split(' ');
                    string[] arr2 = line2.Split(' ');
                    banFirst = int.Parse(arr[0]);
                    banSecond = int.Parse(arr[1]);
                    sumBan = banFirst + banSecond;
                    pakFirst = int.Parse(arr[2]);
                    pakSecond = int.Parse(arr[3]);
                    sumPak = pakFirst + pakSecond;
                    banFirst2 = int.Parse(arr2[0]);
                    banSecond2 = int.Parse(arr2[1]);
                    sumBan2 = banFirst2 + banSecond2;
                    pakFirst = int.Parse(arr[2]);
                    pakSecond = int.Parse(arr[3]);
                    sumPak = pakFirst + pakSecond;
                    pakFirst2 = int.Parse(arr2[2]);
                    pakSecond2 = int.Parse(arr2[3]);
                    sumPak2 = pakFirst2 + pakSecond2;
                }
                if (sumBan > sumPak && sumBan2 > sumPak2)
                    Console.WriteLine("Banglawash");
                else
                    Console.WriteLine("Miss");
            }
                
        }
    }
}
