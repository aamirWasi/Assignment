namespace AbstractClassAssignment
{
    public abstract class ShapeType
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public const float PI = 3.14f;
        public abstract double Result();
        public virtual void GetInfo()
        {
            System.Console.WriteLine($"This is a {Name}");
        }
    }
}
