using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public class AttackAction : ICharacterAction
    {
        public string Name => throw new NotImplementedException();

        public void Execute(PlayerCharacter player, IEnemy enemy)
        {
            throw new NotImplementedException();
        }
    }
}
