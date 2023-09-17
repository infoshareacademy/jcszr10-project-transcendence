using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class PlayerCharacter : BasicCharacter, IPlayerCharacter, IInventory, IHealth, IStatistics
    {
        public int Id { get; set; }

        public CharacterClass CharacterClass { get; set; }
        public int FinishedDungeonIndex { get; set; } = 0;
        public int Expirience { get; set; }
        public int Strength { get; set; }
        public int Intelect { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
        public Weapon MainHandWeapon { get; set; }
        public Weapon OffHandWeapon { get; set; }
        public ICollection<Item> Inventory { get; set; }
        ICollection<Jewelery> IInventory.Jewelery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
