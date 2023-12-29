using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations
{
    public class InventoryManager
    {
        public Item Weapon { get; set; }
        public List<Item> Jewelery { get; set; }
        public List<Item> Inventory { get; set; }
    }
}