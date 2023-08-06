
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public interface ICharacterRace
    {
        public string Description { get; set; }
        public string RaceName { get; set; }
        public string GetCharacterRaceName();
        public int GetCharacterIntelect();
        public int GetCharacterLuck();
        public int GetCharacterStrength();
        public int GetCharacterAgility();
    }
}
