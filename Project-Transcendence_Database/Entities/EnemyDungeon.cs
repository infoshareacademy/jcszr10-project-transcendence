﻿using static Project_Transcendence_Database.Entities.EnumTypes;

namespace Project_Transcendence_Database.Entities
{
    public class EnemyDungeon
    {
        public int Id { get; set; }
        public virtual ICollection<Enemy>? EnemyInDungeon { get; set; }
        public string DungeonStory { get; set; }
        public DungeonType DungeonType { get; set; }
        public int DungeonLevel { get; set; }
    }
}