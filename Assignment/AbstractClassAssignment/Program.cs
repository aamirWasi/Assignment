using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Shape class implementation
            var circle = new Circle();
            circle.Draw();
            var rectangle = new Rectangle();
            rectangle.Draw();

            //ShapeType class implementation

            var shapes = new ShapeType[]
            {
                new Triangle("Triangle",2.4,4.6),
                new Cone("Cone",4.5,7.5)
            };
            foreach (var shape in shapes)
            {
                //shape.GetInfo();
                Console.WriteLine($"{shape.Name}'s area is {shape.Result():f2}");
            }
        }
    }
}
