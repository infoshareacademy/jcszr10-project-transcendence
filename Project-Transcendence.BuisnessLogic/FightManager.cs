using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;

namespace Project_Transcendence.BuisnessLogic
{
    public class FightManager
    {

        private IPlayer _player;
        private IEnemy _enemy;

        public FightManager(IEnemy enemy, IPlayer player)
        {
            _player = player;
            _enemy = enemy;
        }

        public bool Fight()
        {
            bool result = false;
            string x = Console.ReadLine();
            if (x == "x")
            {
                result = true;
            }
            else
            {
                result |= false;
            }
            return result;
        }

    }
}
