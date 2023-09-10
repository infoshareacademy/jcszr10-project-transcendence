
namespace Project_Transcendence_Database.Entities
{
    public class CharacterClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int AbilityId { get; set; }
        public virtual ICollection<Ability>? Ability { get; set; }

        public int PlayerCharacterId { get; set; }
        public virtual ICollection<PlayerCharacter>? PlayerCharacter { get; set; }

        public int ResourceId { get; set; }
        public virtual Resource? Resource { get; set; }
    }
}
