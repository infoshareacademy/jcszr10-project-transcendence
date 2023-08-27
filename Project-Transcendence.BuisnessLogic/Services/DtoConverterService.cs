using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public static class DtoConverterService
    {
        public static PlayerCharacterDTO ConvertToDto(PlayerCharacter _player)
        {

            List<int> weapons = new List<int>();
            List<int> jewelery = new List<int>();
            List<int> inventory = new List<int>();

            foreach (var item in _player.Weapons)
            {
                weapons.Add(item.Id);
                inventory.Add(item.Id);
            }
            foreach (var item in _player.Jewelery)
            {
                jewelery.Add(item.Id);
                inventory.Add(item.Id);
            }

            var stats = _player.StatisticsManager;
            PlayerCharacterDTO result = new(
                _player.Name,
                _player.Race.RaceName,
                _player.Level,
                _player.Id,
                _player.CharacterClass.ClassName,
                _player.Experience,
                _player.HealthManager.Health,
                stats.Agility,
                stats.Intelect,
                stats.Strength,
                stats.Luck,
                _player.FinishedDungeonIndex,
                weapons,
                jewelery,
                inventory
                );


            return result;
        }

        public static PlayerCharacter ConvertFromDto(PlayerCharacterDTO _playerDTO)
        {
            string x = _playerDTO.CharacterClass;
            string y = _playerDTO.Race;

            List<Weapon> weapons = new List<Weapon>();
            List<Jewelery> jeweleries = new List<Jewelery>();
            List<int> inventory = new List<int>();

            foreach (var weapon in _playerDTO.Weapons)
            {
                weapons.Add(ItemList.Weapons.Find(item => item.Id == weapon));
            }
            foreach (var jewelery in _playerDTO.Jewelery)
            {
                jeweleries.Add(ItemList.Jeweleries.Find(item => item.Id == jewelery));
            }

            ICharacterClass characterClass;
            ICharacterRace characterRace;

            characterClass = x switch
            {
                nameof(Monk) => new Monk(),
                nameof(Warrior) => new Warrior(),
                nameof(Rogue) => new Rogue(),
                nameof(Wizard) => new Wizard(),
                _ => new Monk()
            };

            characterRace = y switch
            {
                nameof(Aasimar) => new Aasimar(),
                nameof(Human) => new Human(),
                nameof(HighElf) => new HighElf(),
                nameof(Dwarf) => new Dwarf(),
                _ => new Aasimar()
            };

            PlayerCharacter result = new(_playerDTO.Name, characterRace, characterClass, _playerDTO.Experience, _playerDTO.Level);

            result.StatisticsManager = new();
            result.HealthManager = new();
            result.Id = _playerDTO.Id;
            result.StatisticsManager.Strength = _playerDTO.Strength;
            result.StatisticsManager.Agility = _playerDTO.Agility;
            result.StatisticsManager.Intelect = _playerDTO.Intelect;
            result.StatisticsManager.Luck = _playerDTO.Luck;
            result.HealthManager.Health = _playerDTO.Health;
            result.Weapons = weapons;
            result.Jewelery = jeweleries;
            result.FinishedDungeonIndex = _playerDTO.FinishedDungeonIndex;

            return result;
        }
    }
}
