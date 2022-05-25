using LizardIsland.Data;

namespace LizardIsland.Providers
{
    public class CharacterProvider
    {
        public Player GetNewPlayer()
        {
            Console.Write("\nName: ");

            Player newPlayer = new Player();

            newPlayer.Name = Console.ReadLine();

            if (newPlayer.Name == "")
            {
                newPlayer.Name = "Hero";
            }
            return newPlayer;
        }
        public Enemy.Common GetRanEnemy()
        {
            Enemy.Common ranEnemy = new Enemy.Common();
            return ranEnemy;
        }
        public Enemy GetBoss(string name, int health, int weaponPower, int loot)
        {
            Enemy boss = new Enemy
            {
                Name = name,
                WeaponPower = weaponPower,
                Health = health,
                Loot = loot
            };
            return boss;
        }
    }
}
