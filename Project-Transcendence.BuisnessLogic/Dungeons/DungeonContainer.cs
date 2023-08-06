
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Character.Enemy;

namespace Project_Transcendence.BuisnessLogic.Dungeons
{
    public static class DungeonContainer
    {
        public static List<Enemy> enemies = new()
        {
                new Enemy("Goblin", new Human(), 50, 3),
                new Enemy("Orc", new Human(), 80, 5),
                new Enemy("Skeleton", new Dwarf(), 40, 2),
                new Enemy("Dragon", new Dwarf(), 200, 10),
                new Enemy("Bandit", new HighElf(), 70, 4)
        };

        public static List<IDungeon> Dungeons = new()
        {
            new EnemyDungeon("Historia 1", enemies[0], 1),
            new EnemyDungeon("Historia 2", enemies[1], 2),
            new ShopDungeon(),
            new PuzzleDungeon(),
            new EnemyDungeon("Historia 3", enemies[2], 3),
            new ShopDungeon(),
            new EnemyDungeon("Historia 4", enemies[3], 4),



        };

    }
}
