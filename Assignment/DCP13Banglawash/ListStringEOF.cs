using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP13Banglawash
{
    class ListStringEOF
    {
        static void Main()
        {
            List<string> lines = new List<string>();
            string line;
            int count = -2; // Current member index;
            int totalcount = 0; // Total members count;
            while (count < totalcount)
            {
                line = Console.ReadLine();
                lines.Add(line);
                if (count == -1) // your app doesn't count first and second line
                {
                    totalcount = Convert.ToInt32(line);
                }
                count++;
            }
            getResult(lines);
        }

        private static void getResult(List<string> lines)
        {
            throw new NotImplementedException();
        }
    }
}
