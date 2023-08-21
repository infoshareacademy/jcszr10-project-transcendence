using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;
using Project_Transcendence.BusinessLogic.Fight;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class DungeonRunner
    {
        private IDungeon _dungeon;
        private PlayerCharacter _player;

        private int _turn = 0;
        public DungeonRunner(IDungeon dungeon, PlayerCharacter player)
        {
            _dungeon = dungeon;
            _player = player;
        }

        public bool RunDungeon()
        {
            switch (_dungeon)
            {
                case EnemyDungeon enemyDungeon:
                    break;

                case PuzzleDungeon puzzleDungeon:
                    Console.WriteLine("puzzle");
                    Thread.Sleep(1000);
                    return true;

                case ShopDungeon shopDungeon:
                    Console.WriteLine("shop");
                    Thread.Sleep(1000);
                    return true;
            }
            return false;
        }
    }
}
