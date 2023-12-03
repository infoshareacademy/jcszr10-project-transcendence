using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class DamageCalculatorService : IDamageCalculatorService
    {
        public int? CalculateDamage(PlayerCharacter attacker, Enemy defender, ICharacterAction action)
        {
            return action switch
            {
                AttackAction _ => CalculatePhysicalDamage(attacker, defender),
                CastSpellAction _ => CalculateMagicalDamage(attacker, defender),
                _ => throw new NotImplementedException("Unknown action type.")
            };
        }

        private int CalculatePhysicalDamage(PlayerCharacter attacker, Enemy defender)
        {
            // Physical damage logic
            return 10;
        }

        private int CalculateMagicalDamage(PlayerCharacter attacker, Enemy defender)
        {
            // Magical damage logic
            return 10;
        }

    }
}
