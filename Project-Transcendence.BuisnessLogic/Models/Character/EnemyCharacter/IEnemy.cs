using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Character.EnemyCharacter
{
    public interface IEnemy
    {
        public List<IAbility> EnemyAbilities { get; set; }
        public EnemyType TypeOfEnemy { get; set; }



    }
}
