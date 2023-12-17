
using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class StatisticsService
    {
        private readonly IPlayerCharacter _player;
        public StatisticsService(IPlayerCharacter player)
        {
            _player = player;
        }

      
    }
}
