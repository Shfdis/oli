using System;

namespace nti_zadacha
{
    public class Player
    {
        public void heal(){
            HP = 1000;
        }
        private int _ex;
        public int level { get; set }
        public int HP { get; set; }
        public int Damage { get; set; }
        public int ex {
            get
            {
                return _ex;
            }
            set
            {
                if (_ex > Xp_to_level)
                {
                    Xp_to_level++;
                    level++;
                    _ex = value - Xp_to_level;
                }
                else _ex = value;
            }
        }

        int Xp_to_level = 1;
        int DamageScale;

        public Player(int damageScale)
        {
            level = 1;
            heal();
            DamageScale = damageScale;
        }

    }
}
