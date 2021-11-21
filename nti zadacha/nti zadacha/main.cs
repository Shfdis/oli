using System;

namespace nti_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player(9);

            int i = 1;
            while (i < 20212022)
            {
                Game.Battle(pl, i);
                i++;
            }

            Console.WriteLine($"Potions: {pl.heelcounter} \n" +
                              $"Money: {pl.heelcounter * 19}");
        }
    }
}