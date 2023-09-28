
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public class AbilityBuilder : IAbilityBuilder
    {
        private readonly Ability _ability;
        private readonly AbilityDto _abilityDto;

        public AbilityBuilder(Ability ability, AbilityDto abilityDto)
        {
            _ability = ability;
            _abilityDto = abilityDto;
        }

        public Ability Build()
        {
            return _ability;
        }

        public void SetDamage()
        {
            _ability.Damage = _abilityDto.Damage;
        }

        public void SetDescription()
        {
            _ability.Description = _abilityDto.Description;
        }

        public void SetHealing()
        {
            _ability.Healing = _abilityDto.Healing;
        }

        public void SetId()
        {
            _ability.Id = _abilityDto.Id;
        }

        public void SetName()
        {
            _ability.Name = _abilityDto.Name;
        }

        public void SetResourceCost()
        {
            _ability.ResourceCost = _abilityDto.ResourceCost;
        }

        public void SetType()
        {
            _ability.Type = _abilityDto.ClassType;
        }
    }
}
