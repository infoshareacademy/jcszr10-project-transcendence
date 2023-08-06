using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Human : ICharacterRace
    {

        private StatisticsManager _statisticsManager;
        private string _description;

        public Human()
        {
            _statisticsManager = new StatisticsManager(5, 0, 0, 0);
        }

        //TODO: Design your chosen race #3.
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "Człowiek to dość pospolita rasa, żyje krótko i jest dość słaby w porównaniu do innych inteligentnych gatunków, mimo swoich ograniczeń posiada zdolność szybkiego dostosowania się do zaistniałych warunków, łatwość uczenia się i zdobywania umiejętności, dają mu możliwość wcielania się w dowolną klasę.";
            }
        }

        public string RaceName { get; set; } = "Human";

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
            return "Human";
        }
    }
}
