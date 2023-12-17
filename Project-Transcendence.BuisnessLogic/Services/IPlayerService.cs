using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence_Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IPlayerService
    {
        public Task<PlayerCharacter> CreateNewCharacterAsync(string name, int raceId, int classId);
        public Task<PlayerCharacter> LoadCharacterAsync(int characterId);
        public Task<PlayerCharacter> UpdateCharacterAsync(PlayerCharacterDTO dto);
    }
}
