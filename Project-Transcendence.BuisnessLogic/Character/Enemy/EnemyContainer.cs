using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.Enemy
{
    public static class EnemyContainer
    {

        public static List<IEnemy> Enemies = new List<IEnemy>()
        {
            new Enemy("Bob",new HighElf())
        };


    }
}
