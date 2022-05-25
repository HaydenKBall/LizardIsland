namespace LizardIsland.Data
{
    public class Player
    {
        public Player()
        {
            Name = "Hero";
            Health = 10;
            Armor = 1;
            WeaponPower = 1;
            PotionQty = 3;
            PotionPower = 5;
            PotionsBought = 0;
            Money = 0;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int WeaponPower { get; set; }

        public int Armor { get; set; }

        public int PotionQty { get; set; }

        public int PotionPower { get; set; }

        public int PotionsBought { get; set; }

        public int Money { get; set; }
    }
}
