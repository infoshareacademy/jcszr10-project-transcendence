using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;

namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public interface IBasicCharacter
    {
        public int Id { get; set; }
        public HealthManager Health { get; set; }
        public StatisticsManager Statistics { get; set; }
        public InventoryManager Inventory { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public ICharacterRace Race { get; set; }
    }
}
