using System;

namespace InheritanceAssignment.InheritanceViaInterface
{
    public class ProcessingVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing call for ProcessingVideo service...");
        }
    }
    

}
