
using Project_Transcendence_Database.DataAccess;
using Project_Transcendence_Database.Entities;

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
            var character = new PlayerCharacter
            {
                Name = name,
                CharacterRaceId = raceId,
                CharacterClassId = classId,              
                Level = 1,
                Health = 100,
                Expirience = 0,
                FinishedDungeonIndex = 0,
                Agility = 1,
                Intelect = 1,
                Strength = 1,
                Luck = 1,               
                
            };

            _context.Characters.Add(character);

            await _context.SaveChangesAsync();

            return character;

        }
    }
}
