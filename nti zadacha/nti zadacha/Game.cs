using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nti_zadacha
{
    static class Game
    {   

        public static Monster Gamecycle(Monster monster, int stage)
        {
            //set monster with stage
            if ((stage / 27) == 0)
            {
                monster.Damage = 149;   //Lich
                monster.HP = 400;
                return monster;
            }
            else if ((stage / 18) == 0)
            {
                monster.Damage = 72;    //Necro
                monster.HP = 100;
                return monster;
            }
            else if ((stage / 11) == 0)
            {
                monster.Damage = 35;    //Vamp
                monster.HP = 50;
                return monster;
            }
            else if ((stage / 5) == 0)
            {
                monster.Damage = 17;    //Gnoll
                monster.HP = 30;
                return monster;
            }
            else
            {
                monster.Damage = 10;    //Rat
                monster.HP = 10;
                return monster;
            }



        }
        public static void Battle(Player player, Monster monster, int stage)
        {
            if (player.HP < monster.Damage)
                player.heal();

            player.HP = player.HP - monster.Damage;
            monster.HP = monster.HP - player.Damage;
            //battle with monster

        }


    }
}
