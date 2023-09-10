
namespace Project_Transcendence_Database.Entities
{
    public class User
    {
        public int Id { get; set; }
        public virtual PlayerCharacter? Character { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
