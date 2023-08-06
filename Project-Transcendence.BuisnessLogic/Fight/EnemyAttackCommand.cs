using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class EnemyAttackCommand : ICommand
    {
        private BasicPlayer _player;
        private Enemy _enemy;

        public EnemyAttackCommand(BasicPlayer player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Execute()
        {
            _player.TakeDamage(_enemy.Attack());
            Console.WriteLine("tura przeciwnika");
            Console.WriteLine($"Pzzeciwnik zadał Ci {_enemy.Attack().Damage} obrazen");
            Thread.Sleep(3000);
        }
    }
}
