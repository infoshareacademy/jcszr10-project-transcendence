﻿using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Fight;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    /// <summary>
    /// This Class creates a dungeon with enemies inside. You have to provide: story, list of enemies and level.
    /// </summary>
    public class EnemyDungeon : IDungeon, IEnemyDungeon
    {
        public string DungeonStory { get; set; }
        public Enemy EnemyInDungeon { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }

        public EnemyDungeon(string story, Enemy enemy, int level, string type = "Z przeciwnikiem")
        {
            DungeonStory = story;
            EnemyInDungeon = enemy;
            DungeonLevel = level;
            DungeonType = type;
            Console.WriteLine(DungeonStory);
        }
    }
}
