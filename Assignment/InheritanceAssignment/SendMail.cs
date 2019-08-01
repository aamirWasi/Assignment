using System;

namespace InheritanceAssignment
{
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
}
