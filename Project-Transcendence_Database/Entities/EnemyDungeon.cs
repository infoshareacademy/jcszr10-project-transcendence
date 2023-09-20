
namespace Project_Transcendence_Database.Entities
{
    public class EnemyDungeon
    {
        public virtual ICollection<Enemy> EnemyInDungeon { get; set; }
        public int Id { get; set; }
        public string DungeonStory { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }
    }
}
