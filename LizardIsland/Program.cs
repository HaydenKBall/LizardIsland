using LizardIsland.Extensions;
using LizardIsland.Providers;

namespace LizardIsland
{
    public static class Program
    {
        private static readonly CharacterProvider CharacterProvider = new CharacterProvider();       
        public static void Main()
        {
            StoryExtension.Intro();

            var player = CharacterProvider.GetNewPlayer();

            StoryExtension.Shipwreck(player.Name);

            StoryExtension.Beach();

            var beachEncounter = CharacterProvider.GetBoss("Wounded Imperial Sailor", 5, 1, 15);
            var combatProvider = new CombatProvider(player, beachEncounter);
            combatProvider.Combat();

            StoryExtension.EndBeach(player.Money);

            StoryExtension.JungleIntro();

            var newEnemyOne = CharacterProvider.GetRanEnemy();
            var combatProviderTwo = new CombatProvider(player, newEnemyOne);
            combatProviderTwo.Combat();

            var newEnemyTwo = CharacterProvider.GetRanEnemy();
            var combatProviderThree = new CombatProvider(player, newEnemyTwo);
            combatProviderThree.Combat();

            StoryExtension.JungleMain();
            
        } 
    }
}