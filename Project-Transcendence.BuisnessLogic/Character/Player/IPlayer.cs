using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public interface IPlayer
    {
        public ICharacterClass CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<IItem> Inventory { get; set; }
        public List<IItem> Weapons { get; set; }
        public List<IItem> Jewelery { get; set; }
        public void AddToInventory(IItem item);
        public void AddToWeapons(IItem item);
        public void AddToJewelery(IItem item);
        public void RemoveFromInventory(IItem item);
        public void RemoveFromWeapons(IItem item);
        public void RemoveFromJewelery(IItem item);
        public void AddExperience();
        public string GetCharacterClass();
        public void LevelUp();
    }
}
