using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public interface IPlayer
    {
        public ICharacterClass CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Item> Weapons { get; set; }
        public List<Item> Jewelery { get; set; }
        public void AddToInventory(Item item);
        public void AddToWeapons(Item item);
        public void AddToJewelery(Item item);
        public void RemoveFromInventory(Item item);
        public void RemoveFromWeapons(Item item);
        public void RemoveFromJewelery(Item item);
        public void AddExperience();
        public string GetCharacterClass();
        public void LevelUp();
    }
}
