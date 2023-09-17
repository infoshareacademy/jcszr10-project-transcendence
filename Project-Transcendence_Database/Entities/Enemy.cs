
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Transcendence_Database.Entities
{
    public class Enemy
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }

        [ForeignKey("RaceId")]
        public virtual CharacterRace? Race { get; set; }
        public int RaceId { get; set; }

        public virtual ICollection<Ability>? Abilities { get; set; }
        public virtual ICollection<EnemyDungeon> EnemyDungeons { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
