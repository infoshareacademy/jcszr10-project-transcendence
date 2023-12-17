using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class ActionService : IActionService
    {
        public ICharacterAction ChooseActionForPlayer(PlayerCharacter player)
        {
            // Logika pozwalająca graczowi na wybranie akcji.
            // Może to być realizowane poprzez interakcję z UI.

            // Przykład: Zwróć pierwszą dostępną akcję lub logikę wyboru opartą na UI
            if (player.AvailableActions.Any())
            {
                return player.AvailableActions.First();
            }

            return null; // lub zwróć domyślną akcję
        }
    }
}
