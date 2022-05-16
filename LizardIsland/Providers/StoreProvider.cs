using LizardIsland.Data;

namespace LizardIsland.Providers
{
    public class StoreProvider
    {
        public static void RunStore(Player player)
        {
            int potionPrice;
            int armorPrice;
            int weaponPrice;
            int goldenPrice;

            while (true)
            {
                potionPrice = 5 * (player.PotionsBought + 1);
                armorPrice = 25 * (player.Armor + 1);
                weaponPrice = 50 * (player.WeaponPower + 1);
                goldenPrice = 70;

                Console.Clear();
                Console.WriteLine("+============================================+");
                Console.WriteLine("| MARIE BOUDREAUX's LIZARD ISLAND BOUTIQUE   |");
                Console.WriteLine("+============================================+");
                Console.WriteLine(" (S)abre upgrade:                  $ " + weaponPrice);
                Console.WriteLine(" (B)uckler upgrade:                $ " + armorPrice);
                Console.WriteLine(" (P)otions:                        $ " + potionPrice);
                Console.WriteLine(" (G)olden Monkey:                  $ " + goldenPrice);
                Console.WriteLine(" (E)xit Shop                         ");
                Console.WriteLine("+============================================+");
                Console.WriteLine("      'Got any lizard tails for me?' ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(player.Name + "'s Stats");
                Console.WriteLine("+============================================+");
                Console.WriteLine("Health: " + player.Health);
                Console.WriteLine("Weapon Power: " + player.WeaponPower);
                Console.WriteLine("Armor Level: " + player.Armor);
                Console.WriteLine("Potions: " + player.PotionQty);
                Console.WriteLine("Lizard Tails: " + player.Money);
                Console.WriteLine("+============================================+");

                Console.Write("\nInput key corrosponding to desired purchase: ");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (input == "s" || input == "sabre")
                {
                    TryBuy("sabre", weaponPrice, player);
                }
                else if (input == "b" || input == "buckler")
                {
                    TryBuy("buckler", armorPrice, player);
                }
                else if (input == "p" || input == "potion")
                {
                    TryBuy("potion", potionPrice, player);
                }
                else if (input == "g" || input == "golden")
                {
                    TryBuy("golden", goldenPrice, player);
                }
                else if (input == "e" || input == "exit")
                {
                    Console.Clear();
                    break;
                }
            }

        }
        static void TryBuy(string item, int cost, Player player)
        {
            if (player.Money >= cost)
            {
                if (item == "sabre")
                {
                    player.WeaponPower++;
                }
                else if (item == "buckler")
                {
                    player.Armor++;
                }
                else if (item == "potion")
                {
                    player.PotionQty++;
                    player.PotionsBought++;
                }
                else if (item == "golden")
                {
                    player.WeaponPower++;
                    player.Armor++;
                }
                player.Money -= cost;
            }
            else
            {
                Console.WriteLine("'Well ya don't have enough lizard tails to buy that do ye?'");
                Console.ReadKey();
            }
        }
    }
}
