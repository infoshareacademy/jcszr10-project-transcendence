

using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Services;

namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public class CastSpellAction : ICharacterAction
    {
        public string Name => throw new NotImplementedException();

        private readonly Ability _ability;
        private readonly IDamageCalculatorService _damageCalculatorService;

        public CastSpellAction(Ability ability, IDamageCalculatorService damageCalculatorService)
        {
            _ability = ability;
            _damageCalculatorService = damageCalculatorService;
        }

        public void Execute(PlayerCharacter player, IEnemy enemy)
        {
            
            var spell = player.CharacterClass.Abilities.FirstOrDefault(a => a.Name == _ability.Name) ?? throw new InvalidOperationException("Spell not found");




        }
    }
}
