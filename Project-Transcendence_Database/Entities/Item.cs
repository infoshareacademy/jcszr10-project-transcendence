
using System.ComponentModel.DataAnnotations;
using static Project_Transcendence_Database.Entities.EnumTypes;

namespace Project_Transcendence_Database.Entities
{

    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Intelect { get; set; }
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int Healing { get; set; }
        public ItemType ItemType { get; set; }
        public virtual ICollection<Inventory>? Inventories { get; set; }
    }
}
