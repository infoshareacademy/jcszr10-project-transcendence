

using Project_Transcendence.BuisnessLogic.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public class ShopDungeon : IDungeon
    {
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }

        public ShopDungeon(string story, int level, string type = "Sklep")
        {
            DungeonStory = story;
            DungeonType = type;
            DungeonLevel = level;
        }
        public ShopDungeon()
        {
            
        }

        public bool RunDungeon(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
