using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Enemy
{

    public interface IEnemy
    {
        public int Id { get; set; }
        public ICollection<Ability> Abilities { get; set; }
        public ICollection<Item> ItemsToDrop { get; set; }
    }
}
