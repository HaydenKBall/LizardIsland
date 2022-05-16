using LizardIsland.Data;
using LizardIsland.Extensions;

namespace LizardIsland.Providers
{
    public class CombatProvider
    {
        private readonly Player _player;
        private readonly Enemy _enemy;

        public CombatProvider(Player player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }
        public void Combat()
        {
            while(_enemy.Health > 0)
            {
                Console.Clear();
                Console.WriteLine("+========================================+");
                Console.WriteLine(_player.Name);
                Console.WriteLine("+========================================+");
                Console.WriteLine("| Health: " + _player.Health);
                Console.WriteLine("| Armor: " + _player.Armor);
                Console.WriteLine("| Weapon Power: " + _player.WeaponPower);
                Console.WriteLine("| Potions: " + _player.PotionQty);
                Console.WriteLine("| Lizard Tails: " + _player.Money);
                Console.WriteLine("+========================================+");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("+========================================+");
                Console.WriteLine(_enemy.Name);
                Console.WriteLine("+========================================+");
                Console.WriteLine("| Attack: " + _enemy.WeaponPower);
                Console.WriteLine("| Health: " + _enemy.Health);
                Console.WriteLine("+========================================+");
                Console.WriteLine("|       (A)ttack        (D)efend         |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|           (H)eal     (R)un             |");
                Console.WriteLine("+========================================+");
                Console.WriteLine("");
                Console.Write("Input combat action: ");
                
                var inputAction = Console.ReadLine().ToLower();
                PlayerAction(inputAction);
            }
            _player.Money += _enemy.Loot;
            Console.WriteLine("ENEMY SLAIN. You search it's corpse and find " + _enemy.Loot + " Lizard Tails.");
            Console.ReadKey();            
        }

        private void PlayerAction(string action)
        {
            switch (action)
            {
                case "a":
                    PlayerAttack();
                    break;
                case "d":
                    PlayerDefend();
                    break;
                case "h":
                    PlayerHeal();
                    break;
                case "r":
                    PlayerRun();
                    break;
                default:
                    Console.WriteLine("Enter valid input.");
                    break;
            }
        }

        private void PlayerAttack()
        {
            var totalPower = (_player.WeaponPower + RngExtension.RandomNumber(0, 4));
            _enemy.Health -= totalPower;
            _player.Health -= (_enemy.WeaponPower - _player.Armor);
            if (totalPower < 0)
            {
                totalPower = 0;
            }
            Console.WriteLine("\nYou charge forward and attack with your sabre dealing " + totalPower + " damage." +
                "\nThe " + _enemy.Name + " attacks you back dealing " + (_enemy.WeaponPower - _player.Armor) + " damage.");
            Console.ReadKey();
        }

        private void PlayerDefend()
        {
            var totalPower = (_player.WeaponPower - 4);
            _enemy.Health -= totalPower;
            _player.Health -= (_enemy.WeaponPower / 2);
            if (totalPower < 0)
            {
                totalPower = 0;
            }
            Console.WriteLine("\nYou put yourself into a defensive stance sacrificing power but better protecting you from enemy attacks.");
            Console.WriteLine("\nYou attack the " + _enemy.Name + " dealing " + totalPower + " damage. You are attacked back for " + (_enemy.WeaponPower / 2) + " damage.");
            Console.ReadKey();
        }

        private void PlayerHeal()
        {
            if (_player.PotionQty > 0)
            {
                _player.PotionQty--;
                _player.Health += _player.PotionPower;
                Console.WriteLine("\nYou find one of the healing potions attached to your belt, pull out the cork with your teeth and start drinking." +
             "\nGlug glug glug.");
                Console.WriteLine("\nThe potion heals you for " + _player.PotionPower + ".");
                Console.ReadKey();
            }
            else
            {
                _player.Health -= _enemy.WeaponPower;
                Console.WriteLine("\nYou fool! You are out of potions!");
                Console.WriteLine("\nWhile you are fumbling around your pockets like a dumbass, the " + _enemy.Name + " attacks you for " + (_enemy.WeaponPower - _player.Armor));
                Console.ReadKey();
            }
        }

        private void PlayerRun()
        {
            if(RngExtension.RandomNumber(0, 2) == 0)
            {
                Console.WriteLine("\nYou won the coin toss. You succesfully run away.");
                StoreProvider.RunStore(_player);
                Console.ReadKey();
            }
            else
            {
                _player.Health -= _enemy.WeaponPower;
                Console.WriteLine("\nYou fail to run away. The " + _enemy.Name + "attacks you for " + (_enemy.WeaponPower - _player.Armor) + " damage.");
                Console.ReadKey();
            }
        }
    }
}
