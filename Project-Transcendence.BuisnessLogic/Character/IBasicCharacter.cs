using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;

namespace Project_Transcendence.BuisnessLogic.Character
{
    public interface IBasicCharacter
    {
        public string Name { get; set; }
        public ICharacterRace Race { get; set; }
        public int Level { get; set; }
      
    }
}
