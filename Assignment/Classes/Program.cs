using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberGuess = new NumberGuess();
            numberGuess.InformUser();
            numberGuess.DiscoverNumber();
            numberGuess.Announceresult();
        }
    }
}