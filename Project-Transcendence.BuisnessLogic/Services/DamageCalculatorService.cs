using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class DamageCalculatorService : IDamageCalculatorService
    {
        public int? CalculateDamage(PlayerCharacter attacker, EnemyCharacter defender, ICharacterAction action, Ability ability = null)
        {
            return action switch
            {
                AttackAction _ => CalculatePhysicalDamage(attacker, defender),
                CastSpellAction _ => CalculateMagicalDamage(attacker, defender, ability),
                _ => throw new NotImplementedException("Unknown action type.")
            };
        }

        private int CalculatePhysicalDamage(PlayerCharacter attacker, EnemyCharacter defender)
        {
            int? weaponDamage = attacker.MainHandWeapon.Damage + attacker.OffHandWeapon.Damage;
            int? damage = weaponDamage + attacker.Statistics.Strength;
            return damage ?? 0;
        }

        private int CalculateMagicalDamage(PlayerCharacter attacker, EnemyCharacter defender, Ability ability)
        {
            int? damage = ability.Damage + attacker.Statistics.Intelect;
            return damage ?? 0;
        }

    }
}
