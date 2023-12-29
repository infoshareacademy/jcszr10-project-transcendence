using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.States;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Perks.Ability
{
    public interface IAbility
    {
        public int Id { get; set; }
        public int Damage { get; set; }
        public int Healing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ResourceCost { get; set; }
        public AbilityType Type { get; set; }
        public ResourceType Resource { get; set; }
        public StateType AbilityPower { get; set; } // determines what state is applied to the target ( none = normal damage / healing )
        public int EffectOccurChance { get; set; } // determines a chance of state above to occur
        public IState State { get; set; } // state that is applied to the target

    }
}
