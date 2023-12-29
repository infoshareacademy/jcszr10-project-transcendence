using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.States;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Perks.Ability
{
    public class Ability : IAbility
    {
        public int Damage { get; set; }
        public int Healing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int ResourceCost { get; set; }
        public AbilityType Type { get; set; }
        public ResourceType Resource { get; set; }
        public StateType AbilityPower { get; set; }
        public int EffectOccurChance { get; set; } // 0 - 100 %
        public IState State { get; set; }

        public Ability()
        {
                
        }
    }
}
