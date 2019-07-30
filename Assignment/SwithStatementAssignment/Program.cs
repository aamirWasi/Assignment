using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace SwithStatementAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = new FavouriteSeason();
            season.GetFavouriteSeason(Season.Winter);
        }
    }
}
