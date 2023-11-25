using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence_Database.Entities;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

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
        public int UserId { get; set; }

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
            Race =  nameof(this.Race),
            //Inventory = this.Inventory,
            //Jewelery = this.Jewelery,
            Name = this.Name,
            Level = this.Level,
            RaceId = this.Race.Id,
            ClassId = this.CharacterClass.Id,
            CharacterClass = this.CharacterClass switch
            {
                Monk => ClassType.Monk,
                Warrior => ClassType.Warrior,
                Rogue => ClassType.Rogue,
                Wizard => ClassType.Wizard,
                _ => throw new ArgumentOutOfRangeException(nameof(CharacterClass), "This class doesn't exist")
            }
        };



    }
}
