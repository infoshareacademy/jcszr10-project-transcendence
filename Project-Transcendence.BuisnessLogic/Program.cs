
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence_Database.Entities;

async Task<Item> GetItemByIdAsync(int itemId)
{
    using (var context = new ApplicationDbContext())
    {
        var item = await context.Items.FindAsync(itemId);
        return item;
    }
}


var x = GetItemByIdAsync(1).Result;
ItemDto item = new ItemDto(x);

Console.WriteLine(item.Name);