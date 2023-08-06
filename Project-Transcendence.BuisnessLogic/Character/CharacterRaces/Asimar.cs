
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Aasimar : ICharacterRace
    {
        private StatisticsManager _statisticsManager;
        private string _description;
        public Aasimar()
        {
            _statisticsManager = new StatisticsManager(0,0,0,5);
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "Aasimar to rasa istot występujących w wielu światach fantasy," +
                    " zwykle pochodzących z mieszańców ludzi i istot boskich lub pochodzących bezpośrednio od boskich przodków." +
                    " Posiadają cechy zarówno ludzkie, jak i boskie, co nadaje im wyjątkowe zdolności i wygląd. ";
            }
        }

        public string RaceName { get; set; } = "Aasimar";

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
            return "Aasimar";
        }
    }
}
