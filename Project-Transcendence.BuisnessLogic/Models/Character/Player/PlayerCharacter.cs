using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence_Database.Entities;
using System.Text;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class PlayerCharacter : BasicCharacter, IPlayerCharacter, IInventory, IHealth, IStatistics, IDtoConvertible<PlayerCharacterDTO>
    {
        public int Id { get; set; }
        public ICharacterClass CharacterClass { get; set; }
        public int FinishedDungeonIndex { get; set; } = 0;
        public int Experience { get; set; }
        public Perks.Items.Item MainHandWeapon { get; set; }
        public Perks.Items.Item OffHandWeapon { get; set; }
        public StatisticsManager Statistics { get; set; }
        public List<Perks.Items.Item> Inventory { get; set; }
        public List<Perks.Items.Item> Jewelery { get; set; }
        public int UserId { get; set; }
        public List<ICharacterAction> AvailableActions { get; set; }



        public PlayerCharacterDTO ConvertToDto()
        {
            PlayerCharacterDTO dto = new PlayerCharacterDTO
            {
                Id = this.Id,
                FinishedDungeonIndex = this.FinishedDungeonIndex,
                Experience = this.Experience,
                Name = this.Name,
                Level = this.Level,
                RaceId = this.Race?.Id ?? 0,
                ClassId = this.CharacterClass?.Id ?? 0,
                CharacterClass = this.CharacterClass switch
                {
                    Monk => ClassType.Monk,
                    Warrior => ClassType.Warrior,
                    Rogue => ClassType.Rogue,
                    Wizard => ClassType.Wizard,
                    _ => throw new ArgumentOutOfRangeException(nameof(CharacterClass), "This class doesn't exist")
                }
            };

            if (this.Health != null)
            {
                dto.Health = this.Health.Health;
                dto.MaxHealth = this.Health.MaxHealth;
            }

            if (this.Statistics != null)
            {
                dto.Luck = (int)this.Statistics.Luck;
                dto.Strength = (int)this.Statistics.Strength;
                dto.Agility = (int)this.Statistics.Agility;
                dto.Intelect = (int)this.Statistics.Intelect;
            }

            if (this.MainHandWeapon != null)
            {
                dto.MainHandWeapon = this.MainHandWeapon.ConvertToDto();
            }

            if (this.OffHandWeapon != null)
            {
                dto.OffHandWeapon = this.OffHandWeapon.ConvertToDto();
            }

            if (this.Race != null)
            {
                dto.Race = this.Race.GetType().Name;
            }

            if (this.Inventory != null)
            {
                dto.Inventory = ItemDtos(this.Inventory);
            }

            if (this.Jewelery != null)
            {
                dto.Jewelery = ItemDtos(this.Jewelery);
            }

            return dto;
        }


        private List<ItemDto> ItemDtos(List<Perks.Items.Item> items)
        {
            var result = new List<ItemDto>();

            foreach (var item1 in items)
            {
                var x = item1 as Perks.Items.Item;
                result.Add(x.ConvertToDto());
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"ID: {Id}");
            result.AppendLine($"Name: {Name}");
            result.AppendLine($"Character Class: {CharacterClass?.GetType().Name ?? "Unknown"}");
            result.AppendLine($"Race: {Race?.GetType().Name ?? "Unknown"}");
            result.AppendLine($"Level: {Level}");
            result.AppendLine($"Health: {Health?.Health}/{Health?.MaxHealth}");
            result.AppendLine($"Finished Dungeon Index: {FinishedDungeonIndex}");
            result.AppendLine($"Experience: {Experience}");
            result.AppendLine($"Main Hand Weapon: {MainHandWeapon?.ToString() ?? "None"}");
            result.AppendLine($"Off Hand Weapon: {OffHandWeapon?.ToString() ?? "None"}");
            result.AppendLine($"Statistics: \n Luck = {Statistics?.Luck}\n Strength = {Statistics?.Strength}\n Intelect = {Statistics?.Intelect}\n Agility = {Statistics?.Agility}");
            result.AppendLine($"Inventory: {string.Join(", ", Inventory?.Select(item => item.ToString()) ?? Enumerable.Empty<string>())}");
            result.AppendLine($"Jewelery: {string.Join(", ", Jewelery?.Select(item => item.ToString()) ?? Enumerable.Empty<string>())}");
            result.AppendLine($"User ID: {UserId}");

            return result.ToString();
        }

        public void LevelUp()
        {
            Level++;
            Health.MaxHealth += 10;
            Statistics.Luck += 1;
            Statistics.Strength += 5;
            Statistics.Intelect += 5;
            Statistics.Agility += 5;
        }

    }
}
