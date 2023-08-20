
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Enemy
{
    public static class EnemyContainer
    {

        public static List<IEnemy> Enemies = new List<IEnemy>()
        {
            new Enemy("Bob",new HighElf())
        };


    }
}
