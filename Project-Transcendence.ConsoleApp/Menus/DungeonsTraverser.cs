using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Dungeons;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class DungeonsTraverser
    {
        private BasicPlayer _player;
        private List<IDungeon> _dungeons;

        public DungeonsTraverser(BasicPlayer player, List<IDungeon> dungeons)
        {
            _player = player;
            _dungeons = dungeons;
        }

        public void Traverse()
        {
            foreach (var item in _dungeons)
            {
                Console.WriteLine(item.DungeonStory);
                Thread.Sleep(3000);
                var runDungeon = new DungeonRunner(item,_player);

                if (runDungeon.RunDungeon())
                {
                    _player.LevelUp();
                }
                else
                {
                    GameLostMenu.Run();
                    break;
                }
            }
        }

    }
}
