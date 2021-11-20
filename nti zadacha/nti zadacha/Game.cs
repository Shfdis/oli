using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nti_zadacha
{
    static class Game
    {   
        

        public static Monster spawn( int stage)     //поменьше кода и аргументов
        {
            //set monster with stage
            if ((stage / 27) == 0)
            {
                Monster lich = new Monster(149, 400);  //Lich
                return lich;
            }
            else if ((stage / 18) == 0)
            {
                Monster necro = new Monster(72, 100);   //Necro
                return necro;
            }
            else if ((stage / 11) == 0)
            {
                Monster vamp = new Monster(35, 50);    //Vamp
                return vamp;
            }
            else if ((stage / 5) == 0)
            {
                Monster gnoll = new Monster(17, 30);  //Gnoll
                return gnoll;
            }
            else
            {
                Monster rat = new Monster(10, 10); //Rat
                return rat;
            }


        }
        public static void Battle(Player player,  int stage)
        {
            while (true)
            {
                Monster monster = spawn(stage);
                if (player.HP < monster.Damage)
                {
                    player.heal();
                }

                player.HP = player.HP - monster.Damage;
                monster.HP = monster.HP - player.Damage;
                if (monster.HP <= 0)
                {
                    player.XP += monster.N;
                    return;                                         //полный цикл битвы в одном методе
                }
            }
            //battle with monster

        }
    }
}
