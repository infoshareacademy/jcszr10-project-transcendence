using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class ItemDto : IItem
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
        public StatisticsManager Statistics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ItemDto()
        {
                
        }

        public ItemDto(Project_Transcendence_Database.Entities.Item entity)
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

        public ItemDto(Perks.Items.Item itemModel)
        {
            Id = itemModel.Id;
            Name = itemModel.Name;
            Description = itemModel.Description;
            Damage = itemModel.Damage;
            Armor = itemModel.Armor;
            Agility = itemModel.Statistics.Agility;
            Strength = itemModel.Statistics.Strength;
            Intelect = itemModel.Statistics.Intelect;
            Luck = itemModel.Statistics.Luck;
            Healing = itemModel.Healing;
            ItemType = (ItemType)itemModel.ItemType;
        }

    }
}
