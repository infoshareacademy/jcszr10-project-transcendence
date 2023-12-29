using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations
{
    public class AttackAction : ICharacterAction
    {
        private readonly IDamageCalculatorService _damageCalculatorService;

        public AttackAction(IDamageCalculatorService damageCalculatorService)
        {
            _damageCalculatorService = damageCalculatorService;
        }

        public AttackAction()
        {

        }

        public string Name => "AttackAction";

        public void Execute(IBasicCharacter performer, IBasicCharacter target)
        {
            // Logika ataku, wykorzystując _damageCalculatorService

            target.Health.DecreaseHealth(_damageCalculatorService.CalculateDamage(performer as PlayerCharacter, target as EnemyCharacter, new AttackAction()) ?? 1);

        }
    }
}
