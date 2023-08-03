using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class PlayerAttackCommand : ICommand
    {
        private BasicPlayer _player;
        private Enemy _enemy;

        public PlayerAttackCommand(BasicPlayer player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Execute()
        {
            _enemy.TakeDamage(_player.Weapons[0].Damage);
        }
    }
}
