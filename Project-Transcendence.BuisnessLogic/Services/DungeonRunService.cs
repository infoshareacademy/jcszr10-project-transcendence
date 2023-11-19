using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class DungeonRunService
    {

        private readonly IPlayerCharacter _playerCharacter;
        private readonly StatisticsService _player;

        public DungeonRunService(IPlayerCharacter playerCharacter)
        {
            _playerCharacter = playerCharacter;
            _player = new(_playerCharacter);
        }

        //TODO: Create DungeonRunService 
       
        
    }
}
