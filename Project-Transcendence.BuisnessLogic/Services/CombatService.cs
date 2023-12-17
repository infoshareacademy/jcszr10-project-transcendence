using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;


namespace Project_Transcendence.BuisnessLogic.Services
{
    public class CombatService : ICombatService
    {
        private IActionDirector _actionDirector;
        private IActionService _actionService;

        public CombatService(IActionDirector actionDirector, IActionService actionService)
        {
            _actionDirector = actionDirector;
            _actionService = actionService;
        }

        public void StartBattle(PlayerCharacter player, EnemyCharacter enemy)
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
            ICharacterAction selectedAction = null;

            if (performer is PlayerCharacter player)
            {
                // Logika wybierania akcji przez gracza
                selectedAction = _actionService.ChooseActionForPlayer(player);
            }
            else if (performer is EnemyCharacter enemy)
            {
                // wybieranie akcji przez przeciwnika
            }

            if (selectedAction != null)
            {
                // Wykonanie wybranej akcji
                _actionDirector.PerformAction(performer, selectedAction, target);
            }
            else
            {
                throw new Exception("Nie wybrano akcji");
            }
        }
    }
}
