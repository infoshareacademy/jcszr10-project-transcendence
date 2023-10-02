
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public class DungeonBuilder : IDungeonBuilder
    {
        private readonly DungeonDto _dto;

        private readonly Dungeon _dungeon;


        public Dungeon Build()
        {
            return _dungeon;
        }

        public void SetEnemies()
        {
            throw new NotImplementedException();
        }

        public void SetId()
        {
            throw new NotImplementedException();
        }

        public void SetLevel()
        {
            throw new NotImplementedException();
        }

        public void SetPuzzle()
        {
            throw new NotImplementedException();
        }

        public void SetStory()
        {
            throw new NotImplementedException();
        }

        public void SetType()
        {
            throw new NotImplementedException();
        }
    }
}
