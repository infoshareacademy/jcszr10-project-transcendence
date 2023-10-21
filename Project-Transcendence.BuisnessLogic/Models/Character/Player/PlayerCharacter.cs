using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class PlayerCharacter : BasicCharacter, IPlayerCharacter, IInventory, IHealth, IStatistics, IDtoConvertible<PlayerCharacterDTO>
    {
        public int Id { get; set; }
        public ICharacterClass CharacterClass { get; set; }
        public int FinishedDungeonIndex { get; set; } = 0;
        public int Expirience { get; set; }
        public IItem MainHandWeapon { get; set; }
        public IItem OffHandWeapon { get; set; }
        public StatisticsManager Statistics { get; set; }
        public List<IItem> Inventory { get; set; }
        public List<IItem> Jewelery { get; set; }

        public PlayerCharacterDTO ConvertToDto() => new()
        {
            Id = this.Id,
            FinishedDungeonIndex = this.FinishedDungeonIndex,
            Experience = this.Expirience,
            Health = Health.Health,
            MaxHealth = this.Health.MaxHealth,
            Luck = (int)this.Statistics.Luck,
            Strength = (int)this.Statistics.Strength,
            Agility = (int)this.Statistics.Agility,
            Intelect = (int)this.Statistics.Intelect,
            MainHandWeapon = this.MainHandWeapon,
            OffHandWeapon = this.OffHandWeapon,
            //CharacterClass = nameof(this.CharacterClass),
            Race =  nameof(this.Race),
            Inventory = this.Inventory,
            Jewelery = this.Jewelery,
            Name = this.Name,
            Level = this.Level
        };
    }



}
