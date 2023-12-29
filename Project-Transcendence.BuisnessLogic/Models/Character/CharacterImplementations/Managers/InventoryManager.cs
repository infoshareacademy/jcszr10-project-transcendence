using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.Managers
{
    public class InventoryManager
    {
        public IItem Weapon { get; set; }
        public List<IItem> Jewelery { get; set; }
        public List<IItem> Inventory { get; set; }

        

        public void AddToInventory(IItem item)
        {
            Inventory.Add(item);
        }

        public void RemoveFromInventory(IItem item)
        {
            Inventory.Remove(item);
        }

        public void EquipWeapon(IItem weapon)
        {
            if(Inventory.Contains(weapon))
            {
                Weapon = weapon;
                Inventory.Remove(weapon);
            }
        }   

        public void EquipJewelery(IItem item)
        {
            if(Inventory.Contains(item))
            {
                Jewelery.Add(item);
            }
        }

    }
}