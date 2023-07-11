using Project_Transcendence.BuisnessLogic.Perks;
using Project_Transcendence.ConsoleApp.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public class PuzzleDungeon : IDungeon, IPuzzleDungeon
    {
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }
        public Puzzle PuzzleToSolve { get; set; }

        public PuzzleDungeon(string story,string type, int level, Puzzle puzzle)
        {
            DungeonStory = story;
            DungeonType = type;
            DungeonLevel = level;
            PuzzleToSolve = puzzle;
        }
        public PuzzleDungeon()
        {
            
        }

    }
}
