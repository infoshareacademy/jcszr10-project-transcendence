﻿namespace Project_Transcendence.BuisnessLogic.Models.Dungeons
{
    public class ShopDungeon : IDungeon
    {
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ShopDungeon(string story, int level, string type = "Sklep")
        {
            DungeonStory = story;
            DungeonType = type;
            DungeonLevel = level;
        }
        public ShopDungeon()
        {

        }
    }
}
