
namespace Project_Transcendence_Database.Entities
{
    public class CharacterRace
    {
        public string? Description { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }

        public virtual ICollection<PlayerCharacter>? Characters { get; set; }
        public virtual ICollection<Enemy>? Enemies { get; set; }
    }
}
