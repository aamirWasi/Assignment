using System;

namespace InheritanceAssignment.InheritanceViaInterface
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing for uploading video");
        }
    }
    

}
