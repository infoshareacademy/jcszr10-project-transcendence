using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Fight;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    /// <summary>
    /// This Class creates a dungeon with enemies inside. You have to provide: story, list of enemies and level.
    /// </summary>
    public class EnemyDungeon : IDungeon, IEnemyDungeon
    {
        public string DungeonStory { get; set; }
        public IEnemy EnemyInDungeon { get; set; }
        public string DungeonType { get; set; }
        public int DungeonLevel { get; set; }
        private IPlayer _player;

        public EnemyDungeon(string story, IEnemy enemy, int level, string type = "Z przeciwnikiem")
        {
            DungeonStory = story;
            EnemyInDungeon = enemy;
            DungeonLevel = level;
            DungeonType = type;
        }
        public EnemyDungeon()
        {
            
        }

        public bool RunDungeon(IPlayer player)
        {
            _player = player;

            FightManager fightManager = new FightManager(EnemyInDungeon,_player);

            if (fightManager.Fight())
                return true;
            else 
                return false;

        }
    }
}
