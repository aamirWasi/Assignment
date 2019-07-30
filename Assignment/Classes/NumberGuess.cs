using System;
using System.Linq;

namespace Classes
{
    public class NumberGuess
    {

        #region Public properties

        /// <summary>
        /// public Properties
        /// </summary>

        public int MaxNumber { get; set; }
        public int Guesses { get; private set; }
        public int GuessMin { get; private set; }
        public int GuessMax { get; private set; }
        #endregion


        #region ctor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public NumberGuess()
        {
            MaxNumber = 100;
        }
        #endregion

        #region Thinking number series of user
        /// <summary>
        /// Asks the user think of a number between 0 to MaxNumber
        /// </summary>
        public void InformUser()
        {
            Console.WriteLine($"I want you to think of a number between 0 to {MaxNumber}.Ok?");
            Console.ReadLine();
        }
        #endregion

        #region Discover the thinking number of user's

        /// <summary>
        /// Asks the user the series of number they are thinking of
        /// </summary>
        /// 
        public void DiscoverNumber()
        {
            GuessMax = MaxNumber / 2;
            GuessMin = 0;
            Guesses = 0;
            while (GuessMin != MaxNumber)
            {
                Guesses++;
                Console.WriteLine($"Is your number is between {GuessMin} to {GuessMax} ? Y/N");
                var response = Console.ReadLine();
                if (response?.ToLower().FirstOrDefault() == 'y')
                {
                    MaxNumber = GuessMax;//50
                    GuessMax -= (GuessMax - GuessMin) / 2;//25
                }
                else
                {
                    GuessMin = GuessMax + 1;//51
                    var reminingDifference = MaxNumber - GuessMax;//50
                    GuessMax += (int)Math.Ceiling(reminingDifference / 2f);//75
                }
                if (GuessMin + 1 == MaxNumber)
                {
                    Guesses++;
                    Console.WriteLine($"Is your number is {GuessMin}");
                    response = Console.ReadLine();
                    if (response?.ToLower().FirstOrDefault() == 'y')
                        break;
                    else
                    {
                        GuessMin = MaxNumber;
                        break;
                    }
                }
            }
        }
        #endregion

        #region Result out of numberGuessing game
        /// <summary>
        /// Result out of numberGuessing game
        /// </summary>
        public void Announceresult()
        {
            Console.WriteLine($"** Your number is {GuessMin} **");

            Console.WriteLine($"Guessed in {Guesses} times");
            Console.WriteLine();
        }
        #endregion
    }
}