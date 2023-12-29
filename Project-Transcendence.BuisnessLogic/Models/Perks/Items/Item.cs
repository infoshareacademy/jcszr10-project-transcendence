
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
{
    public class Item : IItem, IDtoConvertible<ItemDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Damage { get; set; }
        public int? Armor { get; set; }
        public int? Healing { get; set; }
        public ItemType ItemType { get; set; }
        public StatisticsManager Statistics { get; set; }

        public ItemDto ConvertToDto() => new()
        {
            Id = this.Id,
            Name = this.Name,
            Description = this.Description,
            Armor = this.Armor,
            Healing = this.Healing,
            Damage = this.Damage,
            ItemType = this.ItemType,
            Luck = this.Statistics.Luck,
            Strength = this.Statistics.Strength,
            Intelect = this.Statistics.Intelect,
            Agility = this.Statistics.Agility
        };


        public override string ToString()
        {
            return $"Id: {Id}, " +
                   $"Name: {Name}, " +
                   $"Description: {Description}, " +
                   $"Damage: {Damage?.ToString() ?? "N/A"}, " +
                   $"Armor: {Armor?.ToString() ?? "N/A"}, " +
                   $"Healing: {Healing?.ToString() ?? "N/A"}, " +
                   $"ItemType: {ItemType}, ";
        }

    }
}
