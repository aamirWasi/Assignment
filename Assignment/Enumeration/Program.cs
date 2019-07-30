using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public enum AnimateDirection
    {
        Right,
        Left,
        Up,
        Down
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animate(AnimateDirection.Down);
            var user = new User();
            if (user.Status == RegistrationStatus.Active &&
                user.Type == UserType.Admin)
            {
                Console.WriteLine("Login in successfully...");
            }
        }
        //Add a Animated Method for Animate Enum

        static void Animate(AnimateDirection direction)
        {
            switch (direction)
            {
                case AnimateDirection.Right:
                    Console.WriteLine("Animating in Right....");
                    break;
                case AnimateDirection.Left:
                    Console.WriteLine("Animating in Left....");

                    break;
                case AnimateDirection.Up:
                    Console.WriteLine("Animating in Up...");

                    break;
                case AnimateDirection.Down:
                    Console.WriteLine("Animating in Down...");

                    break;
                default:
                    Console.WriteLine("I don't know what kinds of animating this is!...");

                    break;
            }
        }
    }
}
