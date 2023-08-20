using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BusinessLogic.Fight;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class PlayerActionMenu
    {
        private string prompt = "Twoja akcja: ";
        private string[] options = { "Atak bronią", "Rzucenie czaru", "Wypicie mikstury" };
        private CommandInvoker _commandInvoker = new CommandInvoker();
        private PlayerCharacter _player;
        private Enemy _enemy;

        public PlayerActionMenu(PlayerCharacter player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Run()
        {
          
        }
    }
}
