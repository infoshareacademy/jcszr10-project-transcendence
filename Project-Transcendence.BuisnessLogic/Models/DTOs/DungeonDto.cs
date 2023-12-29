using Project_Transcendence.BuisnessLogic.Models.Character.EnemyCharacter;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class DungeonDto : IDungeon
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DungeonStory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DungeonLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IPuzzle> Puzzles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IEnemy> Enemies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
