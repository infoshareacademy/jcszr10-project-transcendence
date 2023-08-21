using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BusinessLogic.Fight
{
    public class CastHealingSpellComand : ICommand
    {
        private PlayerCharacter _caster;
        private Ability _ability;

        public CastHealingSpellComand(PlayerCharacter caster, Ability ability)
        {
            _caster = caster;
            _ability = ability;

        }
        public void Execute()
        {
            _caster.HealthManager.DecreaseHealth(_ability.Healing);
        }
    }
}
