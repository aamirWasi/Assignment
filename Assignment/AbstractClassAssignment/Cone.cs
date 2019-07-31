using System;

namespace AbstractClassAssignment
{
    public class Cone : ShapeType
    {
        public Cone(string name,double radius,double height)
        {
            Name = name;
            Radius = radius;
            Height = height;
        }

        public override double Result()
        {
            return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }
}
