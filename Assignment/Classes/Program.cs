using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PersondataCapture
    {
        public static People Capture()
        {
            var output = new People();
            System.Console.WriteLine("What's your FirstName ?");
            output.FirstName = Console.ReadLine();
            System.Console.WriteLine("What's your LastName ?");
            output.LastName = Console.ReadLine();
            return output;
        }
    }
    public class PersonValidator
    {
        public static bool Validate(People people)
        {
            if (string.IsNullOrWhiteSpace(people.FirstName))
            {
                StandardMessages.DisplayValidationError("First Name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(people.LastName))
            {
                StandardMessages.DisplayValidationError("Last Name");
                return false;
            }
            return true;
        }
    }
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application...");
        }
        public static void EndApplication()
        {
            Console.WriteLine("Press enter to close the program...");
        }
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You didn't give us a valid {fieldName}");
        }
    }
    public class AccountGenerator
    {
        public static void CreateAccount(People people)
        {
            Console.WriteLine($"Your username is {people.FirstName.Substring(0,1)}{people.LastName}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //code for guessing number game
            var numberGuess = new NumberGuess();
            numberGuess.InformUser();
            numberGuess.DiscoverNumber();
            numberGuess.Announceresult();

            //SRP implementations

            StandardMessages.WelcomeMessage();
            var user = PersondataCapture.Capture();
            bool IsUserValid = PersonValidator.Validate(user);
            if (IsUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}