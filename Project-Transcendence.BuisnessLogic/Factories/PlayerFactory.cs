using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_Transcendence.BusinessLogic.Factories
{
    public class PlayerFactory
    {
        public IPlayerCharacter Create(string name, ICharacterRace race, ICharacterClass characterClass, int startingHealth = 100, int startingExp = 0, int level = 1)
        {
            var playerCharacter = new PlayerCharacter(name, race, characterClass, startingExp, level);
            PlayerInitializerService playerInitializer = new(playerCharacter);
            playerInitializer.Initialize();
            return playerCharacter;
        }
    }
}
