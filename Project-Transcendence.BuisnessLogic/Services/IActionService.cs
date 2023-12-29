using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.Actions;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IActionService
    {
        ICharacterAction ChooseActionForEnemy(EnemyCharacter enemy);
        ICharacterAction ChooseActionForPlayer(PlayerCharacter player);
    }
}
