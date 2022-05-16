using LizardIsland.Extensions;

namespace LizardIsland.Data
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int WeaponPower { get; set; }
        public int Loot { get; set; }

        public class Common: Enemy
        {
            public Common()
            {
                Name = GetName();
                Health = RngExtension.RandomNumber(8, 12);
                WeaponPower = RngExtension.RandomNumber(1, 6);
                Loot = RngExtension.RandomNumber(4, 11);
            }

            public string GetName()
            {
                switch (RngExtension.RandomNumber(0, 10))
                {
                    case 0:
                        return "Island Crab";
                    case 1:
                        return "Drunken Pirate";
                    case 2:
                        return "Imperial Sailor";
                    case 3:
                        return "Wild Boar";
                    case 4:
                        return "Giant Spider";
                    case 5:
                        return "Banshee";
                    case 6:
                        return "Giant Spider";
                    case 7:
                        return "Flying Skull";
                    case 8:
                        return "Cursed Voodoo Doll";
                    case 9:
                        return "Water Zombie";
                }
                return "Monster";
            }
        }

        public class Boss: Enemy
        {

        }
    }   
}
