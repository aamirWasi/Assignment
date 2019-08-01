using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
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


            //comes from InheritanceViaInterface folder in same project
            System.Console.WriteLine("------------------------------------------------");
            System.Console.WriteLine("comes from InheritanceViaInterface folder in same project");
            var workflowEngine = new WorkFlowEngine();
            workflowEngine.AddActivities(new SendMail());
            workflowEngine.AddActivities(new UploadVideo());
            workflowEngine.AddActivities(new ProcessingVideo());
            workflowEngine.AddActivities(new WebService());

            workflowEngine.Run();
        }
    }
}
