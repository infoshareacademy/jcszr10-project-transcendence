using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces
{
    public class Human : ICharacterRace
    {

        private StatisticsManager _statisticsManager;
        private string _description;
        public string RaceName { get; set; } = "Human";
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
    }
}
