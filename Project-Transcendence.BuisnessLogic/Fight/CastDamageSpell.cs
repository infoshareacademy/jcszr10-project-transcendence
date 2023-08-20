using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BusinessLogic.Fight
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
            _target.HealthManager.DecreaseHealth(_ability.Damage);
            Console.WriteLine($"Uzyles czaru {_ability.Name} i zadales {_ability.Damage} obrazen");
            Thread.Sleep( 2000 );
        }
    }
}
