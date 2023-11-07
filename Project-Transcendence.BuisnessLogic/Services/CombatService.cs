
using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using System.Numerics;
using Microsoft.Extensions.DependencyInjection;
using Project_Transcendence.BuisnessLogic.Models.PlayerCommands;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence_Database.Entities;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class CombatService
    {
        private readonly ApplicationDbContext _context;

        public CombatService(ApplicationDbContext context)
        {
            _context = context;
        }

        async Task<Item> GetItemByIdAsync(int itemId)
        {
            using (var context = _context)
            {
                var item = await context.Items.FindAsync(itemId);
                return item; // To będzie null, jeśli przedmiot nie zostanie znaleziony
            }
        }

    }
}
