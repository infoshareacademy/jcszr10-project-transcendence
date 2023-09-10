using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_Transcendence.BusinessLogic.Factories
{
    public class Factory
    {

        //TODO: Stworzenie fabrykki / buildera postaci

        //public IPlayerCharacter CreatePlayer(string name, ICharacterRace race, ICharacterClass characterClass, int startingHealth = 100, int startingExp = 0, int level = 1)
        //{
        //    var playerCharacter = new PlayerCharacter(name, race, characterClass, startingExp, level);
        //    PlayerInitializerService playerInitializer = new(playerCharacter);
        //    playerInitializer.Initialize();

        //    PlayerService playerService = new(playerCharacter);
        //    playerService.SavePlayer();

        //    return playerCharacter;
        //}

        //public IItem CreateWeapon(string name,string description, int id, int damage)
        //{
        //    return new Weapon(damage,name,description,id);
        //}

        //public IItem CreateJewelery(string name, string description, int id,int inte,int agi, int str, int luck)
        //{
        //    return new Jewelery(name,description,id,inte,agi,str,luck);
        //}

    }
}
