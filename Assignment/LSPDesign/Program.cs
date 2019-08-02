using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDesign
{
    public class SchoolStuff
    {
        private void MakeAnnouncements()
        {
            Console.WriteLine("Make announcements...");
        }
        private void TakeAttendence()
        {
            Console.WriteLine("Take attendence...");
        }
        private void CollectPaperWork()
        {
            Console.WriteLine("Collect Paper work perfectly...");
        }
        private void ConductHallDuties()
        {
            Console.WriteLine("Conduct Hall duties with proper concern....");
        }
        public void PerformOtherResponsibilities()
        {
            MakeAnnouncements();
            TakeAttendence();
            CollectPaperWork();
            ConductHallDuties();
        }
    }
    public class MathTeacher : SchoolStuff,ICourseInstructor
    {
        public void Teach()
        {
            Console.WriteLine("Taught Math");
        }
    }
    public class English : SchoolStuff,ICourseInstructor
    {
        public void Teach()
        {
            Console.WriteLine("Taught English");
        }
    }
    public class Science : SchoolStuff,ICourseInstructor
    {
        public void Teach()
        {
            Console.WriteLine("Taught Science");
        }
    }
    public class SubstituteTeacher : SchoolStuff
    {
        
    }
    //I understood LSP Properly
    class Program
    {
        static void Main(string[] args)
        {
            var mathTeacher = new MathTeacher();
            mathTeacher.Teach();
            mathTeacher.PerformOtherResponsibilities();
        }
    }
}
