using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.PlayerCommands
{
    public class CastAbilityCommand : ICommand
    {
        private readonly IEnemy _enemy;
        private readonly IAbility _ability;

        public CastAbilityCommand(IEnemy enemy, IAbility ability)
        {
            _enemy = enemy;
            _ability = ability;
        }
        public CastAbilityCommand()
        {

        }

        public void Execute()
        {
            var enemyHealth = _enemy as IHealth;

            enemyHealth.HealthManager.DecreaseHealth(_ability.Damage);

        }
    }
}
