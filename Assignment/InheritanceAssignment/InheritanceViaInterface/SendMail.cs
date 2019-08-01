using System;

namespace InheritanceAssignment.InheritanceViaInterface
{
    public class SendMail : IActivity
    {
        public void Execute()
        {
            var numofMails = 0;
            System.Console.WriteLine("How many mails do you want to send ?");
            numofMails = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Executing call for sending mail...{numofMails}");
        }
    }
    

}
