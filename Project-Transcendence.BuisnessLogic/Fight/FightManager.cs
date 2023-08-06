using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class FightManager
    {
        private BasicPlayer _player;
        private Enemy _enemy;
        private CommandInvoker _invoker;

        public FightManager(Enemy enemy, BasicPlayer player)
        {
            _player = player;
            _enemy = enemy;
            _invoker = new CommandInvoker();
        }

        public void Fight(IAbility ability = null, int dmg = 0, int turn = 0)
        {
            Console.WriteLine($"Zycie {_player.Name}: {_player.GetHealth()}");
            Console.WriteLine($"Zycie {_enemy.Name}: {_enemy.GetHealth()}");
            if (turn % 2 == 0)
            {

                if (ability != null)
                {
                    ICommand playerCommand = new CastDamageSpell(_enemy, ability);
                    _invoker.SetCommand(playerCommand);
                    _invoker.ExecuteCommand();
                }
                else
                {
                    ICommand command = new PlayerAttackCommand(_player, _enemy);
                    _invoker.SetCommand(command);
                    _invoker.ExecuteCommand();
                }
            }
            else
            {
                ICommand command = new EnemyAttackCommand(_player, _enemy);
                _invoker.SetCommand(command);
                _invoker.ExecuteCommand();
            }


        }
    }
}
