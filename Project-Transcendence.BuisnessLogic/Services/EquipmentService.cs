
using Microsoft.EntityFrameworkCore;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence_Database.Entities;
using Item = Project_Transcendence_Database.Entities.Item;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly ApplicationDbContext _context;

        public EquipmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Inventory> AddItemToInventory(int itemId, int InventoryId)
        {
            throw new NotImplementedException();
        }

        public Task<Inventory> RemoveItemFromInventory(int itemId, int InventoryId)
        {
            throw new NotImplementedException();
        }
    }
}
