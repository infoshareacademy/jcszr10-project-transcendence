using Project_Transcendence_Database.Entities;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IEquipmentService
    {
        public Task<Inventory> CreateNewInventoryAsync();

        public Task<EquipedJewelery> CreateNewJeweleryAsync();

        public Task<Item> CreateNewMainWeapon();

        public Task<Item> CreateNewOffWeapon();

    }
}