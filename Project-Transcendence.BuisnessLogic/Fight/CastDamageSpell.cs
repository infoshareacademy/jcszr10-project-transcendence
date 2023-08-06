using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    internal class CastDamageSpell : ICommand
    {
        private Enemy _target;
        private IAbility _ability;

        public CastDamageSpell(Enemy target, IAbility ability)
        {
            _target = target;
            _ability = ability;
        }

        public void Execute()
        {
            _target.TakeDamage(_ability.Damage);
            Console.WriteLine($"Uzyles czaru {_ability.Name} i zadales {_ability.Damage} obrazen");
            Thread.Sleep( 2000 );
        }
    }
}
