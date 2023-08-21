using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BusinessLogic.Fight
{
    public class EnemyAttackCommand : ICommand
    {
        private PlayerCharacter _player;
        private Enemy _enemy;

        public EnemyAttackCommand(PlayerCharacter player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Execute()
        {
            //TODO: EnemyAttackCommand do zrobienia
        }
    }
}
