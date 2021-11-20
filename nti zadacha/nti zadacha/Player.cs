using System;

namespace nti_zadacha
{
    public class Player
    {
        public void heal()
        {
            HP = 1000;
        }
        private int fib (int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return fib(n - 1) + fib(n - 2);
        }
        public int Xp_to_level {get; set;}
        int DamageScale;
        private int _xp;
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
                while (_xp > Xp_to_level)
                {
                    if (_xp > Xp_to_level)
                    {
                        level++;
                        Xp_to_level = fib(level);
                        _xp = _xp - Xp_to_level;
                    } 
   
                    else _xp = value;
                }
            }
        }

        public Player(int damageScale)
        {
            Xp_to_level = 1;
            level = 1;
            heal();
            DamageScale = damageScale;
        }

    }
}
