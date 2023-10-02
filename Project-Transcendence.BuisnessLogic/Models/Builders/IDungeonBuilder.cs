
using Project_Transcendence.BuisnessLogic.Models.Dungeons;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public interface IDungeonBuilder
    {
        public void SetId();
        public void SetStory();
        public void SetType();
        public void SetEnemies();
        public void SetPuzzle();
        public void SetLevel();

        public Dungeon Build();
    }
}
