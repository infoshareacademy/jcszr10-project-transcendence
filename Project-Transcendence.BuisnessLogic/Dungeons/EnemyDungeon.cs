using Project_Transcendence.BuisnessLogic.Character.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    /// <summary>
    /// This Class creates a dungeon with enemies inside. You have to provide: story, list of enemies and level.
    /// </summary>
    public class EnemyDungeon : IDungeon, IEnemyDungeon
    {
        public string DungeonStory { get; set; }
        public List<IEnemy> EnemiesInDungeonList { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }

        public EnemyDungeon(string story, List<IEnemy> enemies, int level)
        {
            DungeonStory = story;
            EnemiesInDungeonList = enemies;
            DungeonLevel = level;
        }
        public EnemyDungeon()
        {
            
        }

    }
}
