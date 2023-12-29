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
    }
}
