using Project_Transcendence.BuisnessLogic.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public class PuzzleDungeon : IDungeon, IPuzzleDungeon
    {
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }
        public Puzzle PuzzleToSolve { get; set; }

        public PuzzleDungeon(string story, int level, Puzzle puzzle, string type = "Zagadka")
        {
            DungeonStory = story;
            DungeonType = type;
            DungeonLevel = level;
            PuzzleToSolve = puzzle;
        }
        public PuzzleDungeon()
        {
            
        }

        public bool RunDungeon()
        {
            throw new NotImplementedException();
        }
    }
}
