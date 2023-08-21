using Newtonsoft.Json;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class PlayerCharacter : BasicCharacter, IPlayerCharacter, IInventory
    {
        public int Id { get; set; }
        public ICharacterClass CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<IItem> Inventory { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Jewelery> Jewelery { get; set; }
        public StatisticsManager StatisticsManager { get; set; }
        private int _finishedDungeonIndex = 0;
        private static readonly string _filePath = @"H:\Project_Transcendence\jcszr10-project-transcendence\Project-Transcendence.ConsoleApp\PlayerList.json";

        public PlayerCharacter(string name, ICharacterRace race, ICharacterClass characterClass, int startingExp, int level)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            Level = level;
            Experience = startingExp;
        }
    }
}
