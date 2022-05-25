using LizardIsland.Data;

namespace LizardIsland.Providers
{
    public class CharacterProvider
    {
        public Player CreateNewPlayer()
        {
            Console.Write("\nName: ");

            Player newPlayer = new Player();

            var inputName = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputName))
            {
                newPlayer.Name = inputName;
            }

            return newPlayer;
        }

        public Enemy.Common CreateRandEnemy()
        {
            Enemy.Common randEnemy = new Enemy.Common();

            return randEnemy;
        }

        public Enemy CreateBoss(string name, int health, int weaponPower, int loot)
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
