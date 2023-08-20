using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Enemy
{

    public interface IEnemy
    {
        public int Id { get; set; }
        public List<IAbility> EnemyAttacks { get; set; }
        public List<IItem> ItemsToDrop { get; set; }
    }
}
