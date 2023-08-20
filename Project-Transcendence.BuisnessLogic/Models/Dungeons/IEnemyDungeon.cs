using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;

namespace Project_Transcendence.BuisnessLogic.Models.Dungeons
{
    public interface IEnemyDungeon
    {
        public Enemy EnemyInDungeon { get; set; }
    }
}
