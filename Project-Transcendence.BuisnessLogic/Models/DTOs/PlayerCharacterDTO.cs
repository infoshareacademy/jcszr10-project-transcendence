using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class PlayerCharacterDTO
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public int Id { get; set; }
        public string CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<IItem> Inventory { get; set; }
        public List<IItem> Jewelery { get; set; }
        public IItem MainHandWeapon { get; set; }
        public IItem OffHandWeapon { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Agility { get; set; }
        public int Intelect { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int FinishedDungeonIndex { get; set; }

    }
}
