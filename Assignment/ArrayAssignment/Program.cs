using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{

    class Program
    {
        static void Main(string[] args)
        {
            var weapons = new Weapon[]
            {
                new MachineGun(),
                new Missle()
            };
            foreach (var weapon in weapons)
            {
                weapon.Fire();
            }
            int[] num = new int[7];
            int sum = 0;
            foreach (var value in num)
            {
                int item = int.Parse(Console.ReadLine());
                sum += item;
            }
            Console.WriteLine(sum);

            var names = new string[] {
                "aamir",
                "wasi",
                "rohan"
            };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
