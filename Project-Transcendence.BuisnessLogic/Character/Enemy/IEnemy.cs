using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Enemy
{

    public interface IEnemy
    {

        public List<IAbility> EnemyAttacks { get; set; }
        public IAbility Attack();
        public List<IItem> ItemsToDrop { get; set; }
        public void GiveItem(BasicPlayer player);
    }
}
