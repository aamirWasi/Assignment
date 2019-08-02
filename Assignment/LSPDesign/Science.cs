using System;

namespace LSPDesign
{
    public class Science : SchoolStuff,ICourseInstructor
    {
        public void Teach()
        {
            Console.WriteLine("Taught Science");
        }
    }
}
