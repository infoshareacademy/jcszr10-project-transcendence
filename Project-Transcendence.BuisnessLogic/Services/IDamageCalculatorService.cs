using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IDamageCalculatorService
    {

        int? CalculateDamage(PlayerCharacter attacker, Enemy defender, ICharacterAction action);


    }
}