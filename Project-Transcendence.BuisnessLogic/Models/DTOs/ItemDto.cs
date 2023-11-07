
using Project_Transcendence_Database.Entities;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Damage { get; set; }
        public int? Armor { get; set; }
        public int? Intelect { get; set; }
        public int? Agility { get; set; }
        public int? Strength { get; set; }
        public int? Luck { get; set; }
        public int? Healing { get; set; }
        public ItemType ItemType { get; set; }

        public ItemDto(Item entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Description = entity.Description;
            Damage = entity.Damage;
            Armor = entity.Armor;
            Intelect = entity.Intelect;
            Agility = entity.Agility;
            Strength = entity.Strength;
            Luck = entity.Luck;
            Healing = entity.Healing;
            ItemType = (ItemType)entity.ItemType;
        }     
    }
}
