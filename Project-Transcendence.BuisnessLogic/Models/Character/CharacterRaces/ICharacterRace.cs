
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces
{
    public interface ICharacterRace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StatisticsManager RaceBonusStats { get; set; }
    }
}
