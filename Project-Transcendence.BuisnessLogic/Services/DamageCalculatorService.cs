using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class DamageCalculatorService : IDamageCalculatorService
    {
        public int? CalculateDamage(PlayerCharacter attacker, Enemy defender, ICharacterAction action)
        {

            switch (action)
            {

                case AttackAction:
                    return CalculatePhysicalDamage(attacker, defender);
                    break;

                case CastSpellAction:
                    return CalculateMagicalDamage(attacker, defender);
                    break;

                default:

                    break;


            }

          
        }

        private int CalculatePhysicalDamage(PlayerCharacter attacker, Enemy defender)
        {
            // Physical damage logic
            return 0;
        }

        private int CalculateMagicalDamage(PlayerCharacter attacker, Enemy defender)
        {
            // Magical damage logic
            return 0;
        }

    }
}
