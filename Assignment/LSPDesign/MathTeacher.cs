using System;

namespace LSPDesign
{
    public class MathTeacher : SchoolStuff,ICourseInstructor
    {
        public void Teach()
        {
            Console.WriteLine("Taught Math");
        }
    }
}
