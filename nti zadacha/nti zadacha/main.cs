using System;

namespace nti_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {

            Player pl = new Player(19);

            for (int i = 1; i <= 20212022; i++)
            {
                Game.Battle(pl, i);
            }
            Console.WriteLine(pl.heelcounter * 19);
            Console.ReadKey();

        }
    }
}