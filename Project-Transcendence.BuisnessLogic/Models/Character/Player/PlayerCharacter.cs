using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class PlayerCharacter : BasicCharacter, IPlayerCharacter, IInventory, IHealth, IStatistics
    {
        public int Id { get; set; }
        public ICharacterClass CharacterClass { get; set; }
        public int FinishedDungeonIndex { get; set; } = 0;
        public int Expirience { get; set; }
        public IItem MainHandWeapon { get; set; }
        public IItem OffHandWeapon { get; set; }
        public HealthManager Health { get; set; }
        public StatisticsManager Statistics { get; set; }
        public List<IItem> Inventory { get; set; }
        public List<IItem> Jewelery { get; set; }
    }



}
