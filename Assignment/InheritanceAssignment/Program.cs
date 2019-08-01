using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class WorkFlowEngine
    {
        private List<WorkFlowEngine> _activities;

        public WorkFlowEngine()
        {
            _activities = new List<WorkFlowEngine>();
        }
        public void AddActivities(WorkFlowEngine activity)
        {
            _activities.Add(activity);
        }
        public void Run()
        {
            foreach (var act in _activities)
            {
                act.Execute();
            }
        }
        public virtual void Execute()
        {

        }
    }
    public class ProcessingVideo : WorkFlowEngine
    {
        public override void Execute()
        {
            Console.WriteLine("Executing call for ProcessingVideo service...");
        }
    }
    public class WebService : WorkFlowEngine
    {
        public override void Execute()
        {
            System.Console.WriteLine("Executing call for web service...");
        }
    }
    public class SendMail : WorkFlowEngine
    {
        public override void Execute()
        {
            var numofMails = 0;
            System.Console.WriteLine("How many mails do you want to send ?");
            numofMails = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Executing call for sending mail...{numofMails}");
        }
    }
    public class UploadVideo : WorkFlowEngine
    {
        public override void Execute()
        {
            Console.WriteLine("Executing for uploading video");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text(100);
            System.Console.WriteLine($"Height : {text.Height}");
            text.HyperLink("mypic.jpeg");
            text.Duplicate();


            var workEngine = new WorkFlowEngine();
            workEngine.AddActivities(new SendMail());
            workEngine.AddActivities(new WebService());
            workEngine.AddActivities(new UploadVideo());
            workEngine.AddActivities(new ProcessingVideo());

            workEngine.Run();
        }
    }
}
