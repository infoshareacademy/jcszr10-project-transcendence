
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Dungeons
{
    public interface IDungeon
    {
        public int Id { get; set; }
        public string DungeonStory { get; set; }
        public DungeonType DungeonType { get; set; }
        public int DungeonLevel { get; set; }
        public ICollection<EnemyCharacter> EnemyInDungeon { get; set; }
        public Puzzle PuzzleToSolve { get; set; }
    }
}
