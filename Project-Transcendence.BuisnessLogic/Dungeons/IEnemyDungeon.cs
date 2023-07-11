using Project_Transcendence.ConsoleApp.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public interface IEnemyDungeon
    {
        public List<IEnemy> EnemiesInDungeonList { get; set; }
    }
}
