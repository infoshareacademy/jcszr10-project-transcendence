using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    internal class CastDamageSpellCast : ICommand
    {
        private Enemy _target;
        private Ability _ability;

        public CastDamageSpellCast(Enemy target, Ability ability)
        {
            _target = target;
            _ability = ability;
        }

        public void Execute()
        {
            _target.TakeDamage(_ability.Damage);
        }
    }
}
