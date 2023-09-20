
using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class DungeonInitializerService : IInitializerService
    {
        private readonly IDungeon _dungeon;
        private int _idCounter = 0;

        public DungeonInitializerService(IDungeon dungeon)
        {
            _dungeon = dungeon;
        }

        public void Initialize()
        {
            switch (_dungeon)
            {
                case IEnemyDungeon:
                    var enemyDungeon = _dungeon as IEnemyDungeon;

                   // enemyDungeon.EnemyInDungeon = (Enemy)EnemyContainer.Enemies[new Random().Next(EnemyContainer.Enemies.Count)];
                    _dungeon.DungeonType = "Enemy dungeon";
                    _dungeon.DungeonStory = DungeonStories.Story[new Random().Next(DungeonStories.Story.Count)];
                    _dungeon.DungeonLevel = 1;
                    _dungeon.Id = _idCounter++;

                    break;

                case IPuzzleDungeon:

                    break;

                case IShopDungeon:

                    break;
            }
        }
    }
}
