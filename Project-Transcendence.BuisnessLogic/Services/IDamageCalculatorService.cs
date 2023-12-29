using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IDamageCalculatorService
    {

        int? CalculateDamage(PlayerCharacter attacker, EnemyCharacter defender, ICharacterAction action, Ability ability = null);


    }
}