using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.Actions;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;


namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface IDamageCalculatorService
    {
        int? CalculateDamage(IBasicCharacter attacker, IBasicCharacter defender, ICharacterAction action, Ability ability = null);
    }
}