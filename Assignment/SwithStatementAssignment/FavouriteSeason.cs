using System;

namespace SwithStatementAssignment
{
    public class FavouriteSeason
    {
        public void GetFavouriteSeason(Season season)
        {
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine($"Autumn is very nice season " +
                        $"but i don't like it most");
                    break;
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
                default:
                    Console.WriteLine($"I don't know the season name and it's spafications");
                    break;
            }
        }
    }   
}
