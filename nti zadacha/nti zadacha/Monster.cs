namespace nti_zadacha
{
    public class Monster
    {
        public int XP { get; } // количество опыта за каждого монстра
        public int Damage { get; set; }
        public int HP { get; set; }

        public Monster(int damage, int hp)
        {
            this.XP = 5;                        // n в файлике, 5 поставил для теста
            Damage = damage;
            HP = hp;
        }


    }
}