namespace InheritanceAssignment.InheritanceViaInterface
{
    public class WebService : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Executing call for web service...");
        }
    }
    

}
