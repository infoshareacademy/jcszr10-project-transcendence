using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Dungeons
{
    public class Dungeon : IDungeon, IDtoConvertible<DungeonDto>
    {
        public int Id { get; set; }
        public string DungeonStory { get; set; }
        public DungeonType DungeonType { get; set; }
        public int DungeonLevel { get; set; }
        public ICollection<EnemyCharacter> EnemyInDungeon { get; set; }
        public Puzzle PuzzleToSolve { get; set; }

        public DungeonDto ConvertToDto() => new()
        {
            Id = Id,
        };
    }
}
