using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public class CastSpellAction : ICharacterAction
    {
        public string Name => "Cast Spell";

        private readonly Ability _ability;
        private readonly IDamageCalculatorService _damageCalculatorService;

        public CastSpellAction(Ability ability, IDamageCalculatorService damageCalculatorService)
        {
            _ability = ability;
            _damageCalculatorService = damageCalculatorService;
        }
        public CastSpellAction()
        {
            
        }

        public void Execute(IBasicCharacter performer, IBasicCharacter target)
        {
            target.Health.DecreaseHealth(_damageCalculatorService.CalculateDamage(performer as PlayerCharacter, target as EnemyCharacter, new CastSpellAction(), _ability) ?? 1);
        }
    }
}
