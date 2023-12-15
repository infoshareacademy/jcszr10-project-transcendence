using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public class PlayerCharacterBuilder : ICharacterBuilder
    {
        private readonly PlayerCharacterDTO _dto;
        private readonly PlayerCharacter _playerCharacter;

        public PlayerCharacterBuilder(PlayerCharacterDTO dto)
        {
            _dto = dto;
            _playerCharacter = new PlayerCharacter();
            _playerCharacter.Statistics = new StatisticsManager(0,0,0,0);
        }

        public PlayerCharacter Build()
        {
            return _playerCharacter;
        }

    #nullable disable
        public void SetClass() => _playerCharacter.CharacterClass = _dto.CharacterClass switch
        {
            ClassType.Monk => new Monk(),
            ClassType.Warrior => new Warrior(),
            ClassType.Wizard => new Wizard(),
            ClassType.Rogue => new Rogue(),
            _ => new Warrior()
        };

        public void SetRace() => _playerCharacter.Race = _dto.Race switch
        {
            nameof(Human) => new Human(),
            nameof(Dwarf) => new Dwarf(),
            nameof(Aasimar) => new Aasimar(),
            nameof(HighElf) => new HighElf(),
            _ => new Human()
        };


        public void SetEquipedJewelery()
        {
            _playerCharacter.Jewelery = _dto.Jewelery;
        }

        public void SetExpirience()
        {
            _playerCharacter.Experience = _dto.Experience;
        }

        public void SetFinishedDungeonIndex()
        {
            _playerCharacter.FinishedDungeonIndex = _dto.FinishedDungeonIndex;
        }

        public void SetHealthManager()
        {
            if (_playerCharacter != null && _playerCharacter.Health != null)
            {
                _playerCharacter.Health.Health = _dto.Health;
                _playerCharacter.Health.MaxHealth = _dto.MaxHealth;
            }
        }

        public void SetInventory()
        {
            _playerCharacter.Inventory = _dto.Inventory;
        }

        public void SetLevel()
        {
            _playerCharacter.Level = _dto.Level;
        }

        public void SetMainHandWeapon()
        {
            _playerCharacter.MainHandWeapon = _dto.MainHandWeapon;
        }

        public void SetName()
        {
            if (_playerCharacter != null)
            {
                _playerCharacter.Name = _dto.Name;
            }
        }

        public void SetOffHandWeapon()
        {
            _playerCharacter.OffHandWeapon = _dto.OffHandWeapon;
        }

        public void SetStatisticManager()
        {
            if (_playerCharacter != null && _playerCharacter.Statistics != null)
            {
                _playerCharacter.Statistics.Luck = _dto.Luck;
                _playerCharacter.Statistics.Strength = _dto.Strength;
                _playerCharacter.Statistics.Intelect = _dto.Intelect;
                _playerCharacter.Statistics.Agility = _dto.Agility;
            }
        }

        public void SetId()
        {
            if (_playerCharacter != null)
            {
                _playerCharacter.Id = _dto.Id;
            }
        }

        public void SetUserId()
        {
            _playerCharacter.UserId = _dto.UserId;
        }
    }
}
