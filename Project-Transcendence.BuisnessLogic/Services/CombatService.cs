using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;


namespace Project_Transcendence.BuisnessLogic.Services
{
    public class CombatService : ICombatService
    {
     
        private IActionDirector _actionDirector;

        public CombatService(IActionDirector actionDirector)
        {
            _actionDirector = actionDirector;
        }

        public void StartBattle(PlayerCharacter player, Enemy enemy)
        {
            // Logika zarządzania walką
            while (!player.Health.IsDead() && !enemy.Health.IsDead())
            {
                PerformTurn(player, enemy);
                if (enemy.Health.IsDead()) break;

                PerformTurn(enemy, player);
            }

            // Zakończenie walki



        }

        private void PerformTurn(IBasicCharacter performer, IBasicCharacter target)
        {
            // Logika wybierania i wykonania akcji




        }

    }
}
