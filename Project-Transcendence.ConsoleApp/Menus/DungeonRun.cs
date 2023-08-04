using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Dungeons;
using Project_Transcendence.ConsoleApp.Dungeons;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class DungeonRun
    {
        private IPlayer _player;
        private List<IDungeon> _dungeons = new List<IDungeon>()
        {
            //new EnemyDungeon("Dungeon number 1",new Enemy("Burek", new HighElf()), 1),
            //new EnemyDungeon("Dungeon number 2",new Enemy("Kurek", new HighElf()), 2),
            //new EnemyDungeon("Dungeon number 3",new Enemy("Fiurek", new HighElf()), 3),
            //new PuzzleDungeon("Dungeon number 4",1,new Puzzle())
        };

        public DungeonRun(IPlayer player)
        {
            _player = player;
        }

        public void Traverse()
        {
            foreach (var item in _dungeons)
            {
                if(DungeonInfoDisplay.Run(item))
                {
                    if (item.RunDungeon())
                    {
                        _player.LevelUp();
                    }
                    else
                        GameLostMenu.Run();
                }
                else
                {
                    GameLostMenu.Run();
                }
            }

        }
    }
}
