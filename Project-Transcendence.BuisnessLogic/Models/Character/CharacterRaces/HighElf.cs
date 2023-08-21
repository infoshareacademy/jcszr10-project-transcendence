using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces
{
    public class HighElf : ICharacterRace
    {

        private StatisticsManager _statisticsManager;
        private string _description;
        public string RaceName { get; set; } = "HighElf";
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "Elfy są znanym ze swojego wdzięku magicznym ludem. Elfy wysokie mają bystre umysły i szczycą się znajomością przynajmniej podstaw magii.";
            }
        }
    }
}
