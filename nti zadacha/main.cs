using System;

namespace nti_zadacha
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player(1);
            pl.XP = 10;
            Console.WriteLine(pl.level);
            Console.ReadLine();
        }
    }
}
