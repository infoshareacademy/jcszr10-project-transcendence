using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.EnemyCharacter;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class EnemyDto : IEnemy
    {
        public int Id { get; set; }
        public List<IAbility> EnemyAbilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public GlobalEnums.EnemyType TypeOfEnemy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
        public int Level { get; set; }
        public ICharacterRace Race { get; set; }
    }
}
