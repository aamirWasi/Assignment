namespace AbstractClassAssignment
{
    public class Triangle : ShapeType
    {
        public Triangle(string name,double width,double height)
        {
            Name = name;
            Height = height;
            Width = width;
        }
        public override double Result()
        {
            return 0.5 * Height * Width;
        }
    }
}
