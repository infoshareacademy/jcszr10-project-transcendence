using Project_Transcendence.BuisnessLogic.Models.DTOs;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Perks.Ability
{
    public class Ability : IAbility, IDtoConvertible<AbilityDto>
    {

        public int Damage { get; set; }
        public int Healing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int ResourceCost { get; set; }
        public AbilityType Type { get; set; }

        public Ability(string name, string description, int healing, int damage, int id)
        {
            Id = id;
            Name = name;
            Description = description;
            Healing = healing;
            Damage = damage;
        }

        public AbilityDto ConvertToDto() => new()
        {
            Id = Id,
            Damage = Damage,
            Healing = Healing,
            Description = Description,
            ClassType = Type
        };
    }
}
