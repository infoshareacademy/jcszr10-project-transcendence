using Project_T_WebApp.Models.Ability;
using Project_T_WebApp.Models.Items;

namespace Project_T_WebApp.Models.Character
{
    public class EnemyCharacterModel : BasicCharacterModel
    {
        public int Id { get; set; }
        public List<IAbility> EnemyAttacks { get; set; }
        public List<IItem> ItemsToDrop { get; set; }
    }
}
