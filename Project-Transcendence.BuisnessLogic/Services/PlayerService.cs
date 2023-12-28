
using Microsoft.EntityFrameworkCore;
using Project_Transcendence.BuisnessLogic.Constants;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence_Database.Entities;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class PlayerService : IPlayerService
    {

        private readonly ApplicationDbContext _context;

        public PlayerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PlayerCharacter> CreateNewCharacterAsync(string name, int raceId, int classId)
        {
            var defaultJeweleryItem = await _context.Items.FirstOrDefaultAsync(i => i.Id == DefaultEquipment.JeweleryId);
            var defaultWeaponItem = await _context.Items.FirstOrDefaultAsync(i => i.Id == SetClassDefaultWeaponId(classId));
            var defaultJewelry = new EquipedJewelery
            {
                ItemId = defaultJeweleryItem?.Id
            };

            var character = new PlayerCharacter
            {
                Name = name,
                CharacterRaceId = raceId,
                CharacterClassId = classId,
                Level = 1,
                Health = 100,
                Expirience = 0,
                FinishedDungeonIndex = 0,
                Agility = 10,
                Intelect = 10,
                Strength = 10,
                Luck = 10,
                Inventory = new Inventory(),
                Jewelery = new List<EquipedJewelery> { defaultJewelry},
                MainHandWeapon = defaultWeaponItem,
                OffHandWeapon = defaultWeaponItem
            };

            _context.Characters.Add(character);

            await _context.SaveChangesAsync();

            return character;

        }

        public async Task<PlayerCharacter> LoadCharacterAsync(int characterId)
        {
            var character = await _context.Characters.Include(c => c.Inventory).Include(c => c.Jewelery)
                                                     .Include(c => c.MainHandWeapon).Include(c => c.OffHandWeapon)
                                                     .FirstOrDefaultAsync(i => i.Id == characterId) ?? throw new KeyNotFoundException("Character can't be loaded");

            return character;

        }

        public async Task<PlayerCharacter> UpdateCharacterAsync(PlayerCharacterDTO dto)
        {
            var character = await _context.Characters.FirstOrDefaultAsync(c => c.Id == dto.Id) ?? throw new KeyNotFoundException("Character doesn't exist!");

            character.Name = dto.Name;
            character.Level = dto.Level;
            character.Health = dto.Health;
            character.Expirience = dto.Experience;
            character.FinishedDungeonIndex = dto.FinishedDungeonIndex;
            character.Agility = dto.Agility;
            character.Intelect = dto.Intelect;
            character.Strength = dto.Strength;
            character.Luck = dto.Luck;
            character.CharacterRaceId = dto.RaceId;
            character.CharacterClassId = dto.ClassId;
            //character.Inventory = dto.Inventory;
            //character.Jewelery = dto.Jewelery;
            //character.MainHandWeapon = dto.MainHandWeapon;
            //character.OffHandWeapon = dto.OffHandWeapon;

            await _context.SaveChangesAsync();

            return character;

        }

        private int SetClassDefaultWeaponId(int classId)
        {
            return classId switch
            {
                1 => DefaultEquipment.MonkWeaponId,
                2 => DefaultEquipment.WizardWeaponId,
                3 => DefaultEquipment.RogueWeaponId,
                4 => DefaultEquipment.WarriorWeaponId,
                _ => throw new NotImplementedException()
            };
        }
    }
}
