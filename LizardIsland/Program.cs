using LizardIsland.Extensions;
using LizardIsland.Providers;

namespace LizardIsland
{
    public static class Program
    {
        private static readonly CharacterProvider CharacterProvider = new();       
        public static void Main()
        {
            StoryExtension.Intro();

            var player = CharacterProvider.CreateNewPlayer();

            StoryExtension.Shipwreck(player.Name);

            StoryExtension.Beach();

            var woundedImperialSoldier = CharacterProvider.CreateBoss("Wounded Imperial Sailor", 5, 1, 15);
            var combatProvider = new CombatProvider(player, woundedImperialSoldier);

            combatProvider.Combat();

            StoryExtension.EndBeach(woundedImperialSoldier.Loot);

            StoryExtension.JungleIntro();

            var newEnemyOne = CharacterProvider.CreateRandEnemy();
            var combatProviderTwo = new CombatProvider(player, newEnemyOne);

            combatProviderTwo.Combat();

            var newEnemyTwo = CharacterProvider.CreateRandEnemy();
            var combatProviderThree = new CombatProvider(player, newEnemyTwo);

            combatProviderThree.Combat();

            StoryExtension.JungleMain();
            
        } 
    }
}