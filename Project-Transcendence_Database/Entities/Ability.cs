using System.ComponentModel.DataAnnotations;
using static Project_Transcendence.BuisnessLogic.Globals.ItemList;

namespace Project_Transcendence_Database.Entities
{
    public class Ability
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Damage { get; set; }
        public int Healing { get; set; }
        public int ResourceCost { get; set; }
        [EnumDataType(typeof(AbilityType))]
        public AbilityType ClassType { get; set; }

        public int CharacterClassId { get; set; }
        public virtual CharacterClass? CharacterClass { get; set; }

        public virtual ICollection<Enemy> Enemies { get; set; }

    }
}
 