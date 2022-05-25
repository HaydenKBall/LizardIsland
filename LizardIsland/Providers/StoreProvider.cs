using LizardIsland.Data;

namespace LizardIsland.Providers
{
    public class StoreProvider
    {
        public static void RunStore(Player player)
        {
            while (true)
            {
                var potionPrice = 5 * (player.PotionsBought + 1);
                var armorPrice = 25 * (player.Armor + 1);
                var weaponPrice = 50 * (player.WeaponPower + 1);
                const int goldenPrice = 70;

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

                Console.Write("\nInput key corresponding to desired purchase: ");

                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    input = input.ToLower();

                    if (input is "s" or "sabre")
                    {
                        TryBuy("sabre", weaponPrice, player);
                    }
                    else if (input is "b" or "buckler")
                    {
                        TryBuy("buckler", armorPrice, player);
                    }
                    else if (input is "p" or "potion")
                    {
                        TryBuy("potion", potionPrice, player);
                    }
                    else if (input is "g" or "golden")
                    {
                        TryBuy("golden", goldenPrice, player);
                    }
                    else if (input is "e" or "exit")
                    {
                        break;
                    }
                }
                else
                {
                    RunStore(player);
                }
            }

        }

        private static void TryBuy(string item, int cost, Player player)
        {
            if (player.Money >= cost)
            {
                switch (item)
                {
                    case "sabre":
                        player.WeaponPower++;
                        break;

                    case "buckler":
                        player.Armor++;
                        break;

                    case "potion":
                        player.PotionQty++;
                        player.PotionsBought++;
                        break;

                    case "golden":
                        player.WeaponPower++;
                        player.Armor++;
                        break;
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
