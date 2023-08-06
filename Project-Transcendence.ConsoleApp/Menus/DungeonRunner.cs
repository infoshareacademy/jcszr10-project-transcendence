using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Dungeons;
using Project_Transcendence.BuisnessLogic.Fight;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class DungeonRunner
    {
        private IDungeon _dungeon;
        private BasicPlayer _player;

        private int _turn = 0;
        public DungeonRunner(IDungeon dungeon, BasicPlayer player)
        {
            _dungeon = dungeon;
            _player = player;
        }

        public bool RunDungeon()
        {
            switch (_dungeon)
            {
                case EnemyDungeon enemyDungeon:

                    while (true)
                    {
                        if (_turn % 2 == 0)
                        {
                            PlayerActionMenu playerActionMenu = new(_player, enemyDungeon.EnemyInDungeon);
                            playerActionMenu.Run();
                        }
                        else
                        {
                            FightManager fightManager = new FightManager(enemyDungeon.EnemyInDungeon, _player);
                            fightManager.Fight(null, 0, _turn);
                        }
                        
                        if (enemyDungeon.EnemyInDungeon.GetHealth() <= 0)
                        {
                            Console.WriteLine("Wygrales!");
                            Console.WriteLine("Przechodzisz do następnego poziomu!");
                            Thread.Sleep(1000);
                            return true;
                        }
                        else if (enemyDungeon.EnemyInDungeon.GetHealth() <= 0)
                        {                           
                            return false;
                        }
                        _turn++;
                    }

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
