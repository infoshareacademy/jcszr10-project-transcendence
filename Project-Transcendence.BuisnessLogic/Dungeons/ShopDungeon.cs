

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public class ShopDungeon : IDungeon
    {
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }

        public ShopDungeon(string story, string type, int level)
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
