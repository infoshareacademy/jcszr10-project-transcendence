
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class DungeonDto
    {
        public int Id { get; set; }
        public virtual ICollection<Enemy>? EnemyInDungeon { get; set; }
        public string DungeonStory { get; set; }
        public DungeonType DungeonType { get; set; }
        public int DungeonLevel { get; set; }
    }
}
