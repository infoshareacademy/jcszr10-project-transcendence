using Project_Transcendence.ConsoleApp.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public class EnemyDungeon : IDungeon, IEnemyDungeon
    {
        public string DungeonStory { get; set; }
        public List<IEnemy> EnemiesInDungeonList { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }

        public EnemyDungeon(string story, List<IEnemy> enemies, string type, int level)
        {
            DungeonStory = story;
            EnemiesInDungeonList = enemies;
            DungeonType = type;
            DungeonLevel = level;
        }
        public EnemyDungeon()
        {
            
        }

    }
}
