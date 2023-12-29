using Project_Transcendence.BuisnessLogic.Models.Converters;
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
        public ResourceType Resource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        };
    }
}
