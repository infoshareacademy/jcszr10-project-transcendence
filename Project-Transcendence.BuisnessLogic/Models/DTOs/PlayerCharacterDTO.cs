using Project_Transcendence_Database.Entities;
using System.Text;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;
using Item = Project_Transcendence_Database.Entities.Item;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class PlayerCharacterDTO : IEntityConvertible<PlayerCharacter>
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public int Id { get; set; }
        public ClassType CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<ItemDto>? Inventory { get; set; }
        public List<ItemDto>? Jewelery { get; set; }
        public ItemDto? MainHandWeapon { get; set; }
        public ItemDto? OffHandWeapon { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Agility { get; set; }
        public int Intelect { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int FinishedDungeonIndex { get; set; }
        public int RaceId { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }

        public PlayerCharacter ConvertToEntity() => new()
        {
            Id = this.Id,
            Name = this.Name,
            Level = this.Level,
            CharacterClassId = this.ClassId,
            CharacterRaceId = this.RaceId,
            MainHandWeaponId = this.MainHandWeapon?.Id,
            OffHandWeaponId = this.OffHandWeapon?.Id,
            Intelect = this.Intelect,
            Agility = this.Agility,
            Strength = this.Strength,
            Luck = this.Luck,
            Health = this.Health,
            Expirience = this.Experience,
            FinishedDungeonIndex = this.FinishedDungeonIndex,
            UserId = this.UserId,
        };

        public PlayerCharacterDTO ConvertFromEntity(PlayerCharacter entity) => new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Level = entity.Level,
            Health = entity.Health,
            Agility = entity.Agility,
            Intelect = entity.Intelect,
            Strength = entity.Strength,
            Luck = entity.Luck,
            FinishedDungeonIndex = entity.FinishedDungeonIndex,
            Experience = entity.Expirience,
            RaceId = entity.CharacterRaceId,
            UserId = entity.UserId,
            ClassId = entity.CharacterClassId,

            //TODO: Dokonczyc implementacje ConvertFromEntity() dla PlayerCharacterDTO
            Inventory = ItemConverter(entity.Inventory.Items.ToList()),
            MainHandWeapon = new ItemDto(entity.MainHandWeapon),
            OffHandWeapon = new ItemDto(entity.OffHandWeapon),
            Jewelery = null    
        };

        private List<ItemDto> ItemConverter(List<Item> itemEntities)
        {
            var result = new List<ItemDto>();

            foreach (var item in itemEntities)
            {
                result.Add(new ItemDto(item));
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"ID: {Id}");
            result.AppendLine($"Name: {Name}");
            result.AppendLine($"Character Class: {CharacterClass}");
            result.AppendLine($"Race: {Race}");
            result.AppendLine($"Level: {Level}");
            result.AppendLine($"Health: {Health}/{MaxHealth}");
            result.AppendLine($"Finished Dungeon Index: {FinishedDungeonIndex}");
            result.AppendLine($"Experience: {Experience}");
            result.AppendLine($"Main Hand Weapon: {MainHandWeapon.ToString() ?? "None"}");
            result.AppendLine($"Off Hand Weapon: {OffHandWeapon.ToString() ?? "None"}");
            result.AppendLine($"Statistics: Luck={Luck}, Strength={Strength}, Intelect={Intelect}, Agility={Agility}");
            result.AppendLine($"Inventory: {string.Join(", ", Inventory?.Select(item => item.ToString()) ?? Enumerable.Empty<string>())}");
            result.AppendLine($"Jewelery: {string.Join(", ", Jewelery?.Select(item => item.ToString()) ?? Enumerable.Empty<string>())}");
            result.AppendLine($"User ID: {UserId}");

            return result.ToString();
        }


    }
}
