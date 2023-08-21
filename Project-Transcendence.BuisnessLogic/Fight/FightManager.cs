using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BusinessLogic.Fight
{
    public class FightManager
    {
        private PlayerCharacter _player;
        private Enemy _enemy;
        private CommandInvoker _invoker;

        public FightManager(Enemy enemy, PlayerCharacter player)
        {
            _player = player;
            _enemy = enemy;
            _invoker = new CommandInvoker();
        }

      
    }
}
