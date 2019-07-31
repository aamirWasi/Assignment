using System;

namespace AbstractClassAssignment
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Draw a Rectangle...");
        }
    }
}
