using System;

namespace nti_zadacha
{
    public class Player 
    {
        public int HP { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }

        int Xp_to_level = 1;
        int DamageScale;

        public Player(int damageScale)
        {
            DamageScale = damageScale;
        }

    }
}
