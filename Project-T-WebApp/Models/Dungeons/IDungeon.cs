﻿namespace Project_T_WebApp.Models.Dungeons
{
    public interface IDungeon
    {
        public int Id { get; set; }
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }
    }
}