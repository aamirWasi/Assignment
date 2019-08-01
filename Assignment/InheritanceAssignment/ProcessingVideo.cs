using System;

namespace InheritanceAssignment
{
    public class ProcessingVideo : WorkFlowEngine
    {
        public override void Execute()
        {
            Console.WriteLine("Executing call for ProcessingVideo service...");
        }
    }
}
