using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public interface IInventory
    {
        public void AddToInventory(Item item);
        public void AddToJewelery(Item item);
        public void AddToWeapons(Item item);
        public void RemoveFromInventory(Item item);
        public void RemoveFromJewelery(Item item);
        public void RemoveFromWeapons(Item item);
    }
}
