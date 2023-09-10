using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public interface IInventory
    {
        public ICollection<Item> Inventory { get; set; }
        public Weapon MainHandWeapon { get; set; }
        public Weapon OffHandWeapon { get; set; }
        public ICollection<Jewelery> Jewelery { get; set; }
    }
}
