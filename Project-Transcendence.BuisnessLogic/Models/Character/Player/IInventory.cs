using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public interface IInventory
    {
        public List<IItem> Inventory { get; set; }
        public IItem MainHandWeapon { get; set; }
        public IItem OffHandWeapon { get; set; }
        public List<IItem> Jewelery { get; set; }
    }
}
