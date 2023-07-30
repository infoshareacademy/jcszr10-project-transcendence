using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;

namespace Project_Transcendence.BuisnessLogic.Character.Enemy
{
    public static class EnemyContainer
    {

        public static List<IEnemy> Enemies = new List<IEnemy>()
        {
            new Enemy("Bob",new HighElf())
        };


    }
}
