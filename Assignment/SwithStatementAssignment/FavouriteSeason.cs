using System;

namespace SwithStatementAssignment
{
    public class FavouriteSeason
    {
        public void GetFavouriteSeason(Season season)
        {
            switch (season)
            {
                
                case Season.Winter:
                    Console.WriteLine($"My favourite season is winter");
                    break;
                case Season.Summer:
                    Console.WriteLine($"This is the hottest season and " +
                        $"this season is perfact for going sea beach");
                    break;
                case Season.Spring:
                    Console.WriteLine($"This is the most favourite season for all and" +
                        $" it's named the Queen season");
                    break;
                case Season.Autumn:
                case Season.LateAutumn:
                    Console.WriteLine($"This is season that makes my mood very happy.");
                    break;
                default:
                    Console.WriteLine($"I don't know the season name and it's spafications");
                    break;
            }
        }
    }   
}
