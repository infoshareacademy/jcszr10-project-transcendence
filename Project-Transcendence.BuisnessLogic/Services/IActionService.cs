using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IActionService
    {
        public ICharacterAction ChooseActionForPlayer(PlayerCharacter player);
    }
}
