using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence_Database.Entities;
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
        public IItem? MainHandWeapon { get; set; }
        public IItem? OffHandWeapon { get; set; }
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

        private ICollection<Item> MapItems(List<IItem> items)
        {
            var mappedItems = new List<Item>();
            foreach (var iItem in items)
            {
                var item = new Item
                {
                    Id = iItem.Id,
                    Name = iItem.Name,
                    Description = iItem.Description,
                    Damage = iItem.Damage,
                    Armor = iItem.Armor,
                    Intelect = iItem.Statistics.Intelect,
                    Agility = iItem.Statistics.Agility,
                    Strength = iItem.Statistics.Strength,
                    Luck = iItem.Statistics.Luck,
                    Healing = iItem.Healing,
                    ItemType = (EnumTypes.ItemType)iItem.ItemType
                };
                mappedItems.Add(item);
            }
            return mappedItems;
        }


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
            //Inventory = new Inventory
            //{
            //    Items = Inventory != null ? new HashSet<Item>(MapItems(Inventory)) : null
            //},
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
            Inventory = ConvertoToDtoList(entity),
            
        };

        private List<ItemDto> ConvertInventory(PlayerCharacter entity)
        {
            var result = new List<ItemDto>();

            var itemsFromPlayerInventory = entity.Inventory.Items;

            foreach (var item in itemsFromPlayerInventory)
            {
                result.Add(new ItemDto(item));
            }

            return result;
        }

        private List<ItemDto> ConvertoToDtoList(PlayerCharacter entity)
        {
            var result = new List<ItemDto>();

            var itemsFromPlayerJewelery = entity.Jewelery;

            foreach (var item in itemsFromPlayerJewelery)
            {
                //result.Add(new ItemDto(item));
            }

            return result;
        }

    }
}
