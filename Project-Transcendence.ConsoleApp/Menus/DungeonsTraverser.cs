using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class DungeonsTraverser
    {
        private PlayerCharacter _player;
        private List<IDungeon> _dungeons;

        public DungeonsTraverser(PlayerCharacter player, List<IDungeon> dungeons)
        {
            _player = player;
            _dungeons = dungeons;
        }

        public void Traverse()
        {
           
        }

    }
}
