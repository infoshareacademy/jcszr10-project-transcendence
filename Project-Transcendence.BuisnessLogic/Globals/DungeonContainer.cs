using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;

namespace Project_Transcendence.BuisnessLogic.Globals
{
    public static class DungeonContainer
    {
        public static List<IDungeon> Dungeons = new()
        {
            new EnemyDungeon(),
            new EnemyDungeon(),
            new EnemyDungeon(),
            new EnemyDungeon(),
            new EnemyDungeon()

        };
    }
}
