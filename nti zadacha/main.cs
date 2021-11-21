using System;

namespace nti_zadacha
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player(10);
            battle(pl, 27);
            Console.WriteLine(pl.HP);
        }
    }
}
