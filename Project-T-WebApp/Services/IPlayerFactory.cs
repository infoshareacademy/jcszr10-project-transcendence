using Project_T_WebApp.Models.Character;
using Project_T_WebApp.Models.Classes;
using Project_T_WebApp.Models.Races;

namespace Project_T_WebApp.Services
{
    public interface IPlayerFactory
    {
        IPlayer CreatePlayer(string playerName, string gender, ICharacterRace race, ICharacterClass characterClass, int startingHealth, int startingExp, int level);
    }
}
