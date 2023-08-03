using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Perks.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    internal class CastDamageSpellCast : ICommand
    {
        private BasicCharacter _caster;
        private BasicCharacter _target;
        private Ability _ability;

        public CastDamageSpellCast(BasicCharacter caster, BasicCharacter target, Ability ability)
        {
            _caster = caster;
            _target = target;
            _ability = ability;
        }

        public void Execute()
        {
            _target.TakeDamage(_ability.Damage);
        }
    }
}
