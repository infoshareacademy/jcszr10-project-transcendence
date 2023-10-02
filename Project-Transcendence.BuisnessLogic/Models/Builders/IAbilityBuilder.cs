

using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public interface IAbilityBuilder
    {
        public void SetName();
        public void SetDescription();
        public void SetId();
        public void SetDamage();
        public void SetHealing();
        public void SetType();
        public void SetResourceCost();

        public Ability Build();
    }
}
