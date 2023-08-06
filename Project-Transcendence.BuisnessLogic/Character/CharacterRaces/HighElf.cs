
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class HighElf : ICharacterRace
    {

        private StatisticsManager _statisticsManager;
        private string _description;

        public HighElf()
        {
            _statisticsManager = new StatisticsManager(0, 5, 0, 0);
        }

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

        public string RaceName { get; set; } = "HighElf";

        public int GetCharacterAgility()
        {
            return _statisticsManager.Agility;
        }

        public int GetCharacterIntelect()
        {
            return _statisticsManager.Intelect;
        }

        public int GetCharacterLuck()
        {
            return _statisticsManager.Luck;
        }

        public int GetCharacterStrength()
        {
            return _statisticsManager.Strength;
        }

        public string GetCharacterRaceName()
        {
            return "HighElf";
        }
    }
}
