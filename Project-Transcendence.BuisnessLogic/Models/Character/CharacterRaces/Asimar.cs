using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces
{
    public class Aasimar : ICharacterRace
    {
        private StatisticsManager _statisticsManager;
        private string _description;
        public string RaceName { get; set; } = "Aasimar";
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


    }
}
