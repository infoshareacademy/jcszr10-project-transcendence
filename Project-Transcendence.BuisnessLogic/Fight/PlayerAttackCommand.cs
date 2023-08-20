using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BusinessLogic.Fight
{
    public class PlayerAttackCommand : ICommand
    {
        private PlayerCharacter _player;
        private Enemy _enemy;

        public PlayerAttackCommand(PlayerCharacter player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Execute()
        {
            _enemy.HealthManager.DecreaseHealth(_player.Weapons[0].Damage);
            Console.WriteLine($"Uderzyles przeciwnika {_player.Weapons[0].Name} i zadales {_player.Weapons[0].Damage} obrazen");
            Thread.Sleep(2000);
        }
    }
}
