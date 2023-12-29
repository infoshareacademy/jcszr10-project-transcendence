using Project_Transcendence.BuisnessLogic.Models.Character.EnemyCharacter;
using Project_Transcendence.BuisnessLogic.Models.DTOs;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Dungeons
{
    public class Dungeon : IDungeon, IDtoConvertible<DungeonDto>
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DungeonStory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DungeonLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IPuzzle> Puzzles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IEnemy> Enemies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DungeonDto ConvertToDto() => new()
        {
           
        };
    }
}
