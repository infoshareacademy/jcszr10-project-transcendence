using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public interface IInventory
    {
        public List<Item> Inventory { get; set; }
        public Item MainHandWeapon { get; set; }
        public Item OffHandWeapon { get; set; }
        public List<Item> Jewelery { get; set; }
    }
}
