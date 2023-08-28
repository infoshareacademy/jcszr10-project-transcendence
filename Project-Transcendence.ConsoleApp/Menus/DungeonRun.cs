
using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class DungeonRun
    {

        private readonly IPlayerCharacter _player;
        private readonly List<IDungeon> _dungeons;
        private CombatService _combatService;
        private readonly StatisticsService _statisticsService;
        private readonly PlayerService _playerService;

        public DungeonRun(IPlayerCharacter player, List<IDungeon> dungeons)
        {
            _player = player;
            _dungeons = dungeons;
            _statisticsService = new(_player);
            _playerService = new(_player);
        }



        public void Run()
        {

            for (int i = _player.FinishedDungeonIndex; i < _dungeons.Count; i++)
            {

                DisplayDungeonInfo(_dungeons[i]);
                var enemyDungeon = _dungeons[i] as IEnemyDungeon;
                var enemyHealth = enemyDungeon.EnemyInDungeon as IHealth;
                var playerHealth = _player as IHealth;
                Console.WriteLine("Enemy health: " + enemyHealth.HealthManager.Health);
                Console.WriteLine("Player health: " + playerHealth.HealthManager.Health);

                if (EnterTheDungeon())
                {
                    while (true)
                    {
                        if (Continue(_dungeons[i]))
                        {
                            _combatService = new(_player, enemyDungeon.EnemyInDungeon);
                            PlayerActionMenu playerActionMenu = new(_player, enemyDungeon.EnemyInDungeon);
                            var playerAction = playerActionMenu.ChoseAction();
                            CombatService combat = new(_player, enemyDungeon.EnemyInDungeon);
                            combat.CombatRound(true, playerAction);

                            if (playerHealth.HealthManager.Health <= 0)
                            {
                                Console.WriteLine("Przegrales!");
                                Thread.Sleep(3000);
                                GameLostMenu.Run();
                                break;
                            }
                            else if (enemyHealth.HealthManager.Health <= 0)
                            {
                                Console.WriteLine("Wygrales!");
                                _player.FinishedDungeonIndex = i;
                                _statisticsService.LevelUp();
                                _playerService.SavePlayer();
                                break;
                            }
                        }
                    }
                }
                else
                {
                    MainMenu.Run();
                    break;
                }
            }
        }

        public void DisplayDungeonInfo(IDungeon dungeon)
        {
            switch (dungeon)
            {

                case IEnemyDungeon:
                    var enemyDungeon = dungeon as IEnemyDungeon;

                    Console.WriteLine("Historia: " + dungeon.DungeonStory);
                    Console.WriteLine("Typ: " + dungeon.DungeonType);
                    Console.WriteLine("Przeciwnik: " + enemyDungeon.EnemyInDungeon.Name);

                    break;

                case IPuzzleDungeon:
                    var puzzleDungeon = dungeon as IPuzzleDungeon;

                    throw new NotImplementedException();


                case IShopDungeon:
                    var shopDungeon = dungeon as IShopDungeon;

                    throw new NotImplementedException();


                default:
                    throw new NotImplementedException();
            }
        }

        public bool Continue(IDungeon dungeon)
        {
            var enemyDung = dungeon as IEnemyDungeon;
            var enemyHealth = enemyDung.EnemyInDungeon as IHealth;
            var playerHealth = _player as IHealth;
            Console.WriteLine("Walka dalej trwa!");
            Console.WriteLine("Enemy health: " + enemyHealth.HealthManager.Health);
            Console.WriteLine("Player health: " + playerHealth.HealthManager.Health);
            Console.WriteLine("Enter - kontynuacja / Esc - ucieczka");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }

        public bool EnterTheDungeon()
        {

            Console.WriteLine("Czy chcesz rozpocząć walkę na tym poziomie? ");
            Console.WriteLine("Enter - tak / Esc - nie");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }

    }
}
