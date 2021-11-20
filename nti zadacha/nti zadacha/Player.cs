using System;

namespace nti_zadacha
{
    public class Player
    {

        private int _xp=0;
        public int level { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }
        public int XP {
            get
            {
                return _xp;
            }
            set
            {
                _xp = value;
                if (_xp >= Xp_to_level)
                {
                    while (_xp >= Xp_to_level)
                    {

                        Xp_to_level++;
                        level++;
                        _xp = value - Xp_to_level;
                    } 
                }
                else _xp = value;
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
        public void heal()
        {
            HP = 1000;
        }

    }
}
