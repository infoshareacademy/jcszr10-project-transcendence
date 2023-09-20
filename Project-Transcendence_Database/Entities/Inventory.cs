
namespace Project_Transcendence_Database.Entities
{
    public class Inventory
    {
        public int Id { get; set; }

        public int? PlayerCharacterId { get; set; }
        public virtual PlayerCharacter PlayerCharacter { get; set; }

        public int? EnemyId { get; set; }
        public virtual Enemy Enemy { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}
