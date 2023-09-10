
namespace Project_Transcendence_Database.Entities
{
    public class Weapon
    {
        public int Damage { get; set; }

        public int PlayerCharacterId { get; set; }
        public virtual ICollection<PlayerCharacter> PlayerCharacter { get; set; }

    }
}
