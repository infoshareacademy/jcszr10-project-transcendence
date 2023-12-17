using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Transcendence_Database.Entities
{
    public class EquipedJewelery
    {

        public int? PlayerCharacterId { get; set; }

        [ForeignKey("Item")]
        public int? ItemId { get; set; }

        public virtual Item Item { get; set; }

    }
}
 