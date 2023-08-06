using Project_Transcendence.BuisnessLogic.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public interface IDungeon
    {
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }
    }
}
