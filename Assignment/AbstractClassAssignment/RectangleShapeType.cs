namespace AbstractClassAssignment
{
    public class RectangleShapeType : ShapeType
    {
        public RectangleShapeType(string name,double height,double width)
        {
            Name = name;
            Height = height;
            Width = width;
        }
        public override double Result()
        {
            return Width * Height;
        }
    }
}
