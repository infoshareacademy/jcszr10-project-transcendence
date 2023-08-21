using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public interface IInventory
    {
        public List<IItem> Inventory { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Jewelery> Jewelery { get; set; }
    }
}
