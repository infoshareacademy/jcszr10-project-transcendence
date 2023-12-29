using Project_Transcendence.BuisnessLogic.Models.Character.EnemyCharacter;

namespace Project_Transcendence.BuisnessLogic.Models.Dungeons
{
    public interface IDungeon
    {
        public int Id { get; set; }
        public string DungeonStory { get; set; }
        public int DungeonLevel { get; set; }
        public List<Puzzle> Puzzles { get; set; }
        public List<Enemy> Enemies { get; set; }
    }
}
