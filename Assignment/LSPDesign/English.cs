using System;

namespace LSPDesign
{
    public class English : SchoolStuff,ICourseInstructor
    {
        public void Teach()
        {
            Console.WriteLine("Taught English");
        }
    }
}
