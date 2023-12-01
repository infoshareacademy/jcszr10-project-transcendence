using Project_Transcendence_Database.Entities;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IEquipmentService
    {

        public Task<Inventory> AddItemToInventory(int itemId, int InventoryId);
        public Task<Inventory> RemoveItemFromInventory(int itemId, int InventoryId);
        public Task<Inventory>

    }
}