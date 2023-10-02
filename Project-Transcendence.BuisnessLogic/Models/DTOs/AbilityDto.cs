using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class AbilityDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Damage { get; set; }
        public int Healing { get; set; }
        public int ResourceCost { get; set; }
        public AbilityType ClassType { get; set; }
    }
}
