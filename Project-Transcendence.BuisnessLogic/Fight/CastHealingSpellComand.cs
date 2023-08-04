using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class CastHealingSpellComand : ICommand
    {
        private BasicPlayer _caster;
        private Ability _ability;

        public CastHealingSpellComand(BasicPlayer caster, Ability ability)
        {
            _caster = caster;
            _ability = ability;

        }
        public void Execute()
        {
            _caster.TakeHealth(_ability.Healing);
        }
    }
}
