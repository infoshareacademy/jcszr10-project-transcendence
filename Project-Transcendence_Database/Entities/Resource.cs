
namespace Project_Transcendence_Database.Entities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }

        public virtual ICollection<CharacterClass> CharacterClass { get; set; }
    }
}
