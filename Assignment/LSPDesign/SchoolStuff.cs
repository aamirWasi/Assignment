using System;

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
}
