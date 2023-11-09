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
        private readonly PlayerCharacter _playerCharacter = null!;

        public PlayerCharacterBuilder(PlayerCharacterDTO dto)
        {
            _dto = dto;
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
            throw new NotImplementedException();
        }

        public void SetExpirience()
        {
            _playerCharacter.Expirience = _dto.Experience;
        }

        public void SetFinishedDungeonIndex()
        {
            _playerCharacter.FinishedDungeonIndex = _dto.FinishedDungeonIndex;
        }

        public void SetHealthManager()
        {
            _playerCharacter.Health.Health = _dto.Health;
            _playerCharacter.Health.MaxHealth = _dto.MaxHealth;
        }

        public void SetInventory()
        {
            throw new NotImplementedException();
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
            _playerCharacter.Name = _dto.Name;
        }

        public void SetOffHandWeapon()
        {
            _playerCharacter.OffHandWeapon = _dto.OffHandWeapon;
        }

        public void SetStatisticManager()
        {
            _playerCharacter.Statistics.Luck = _dto.Luck;
            _playerCharacter.Statistics.Strength = _dto.Strength;
            _playerCharacter.Statistics.Intelect = _dto.Intelect;
            _playerCharacter.Statistics.Agility = _dto.Agility;
        }

        public void SetId()
        {
            _playerCharacter.Id = _dto.Id;
        }

        public void SetUserId()
        {
            _playerCharacter.UserId = _dto.UserId;
        }
    }
}
