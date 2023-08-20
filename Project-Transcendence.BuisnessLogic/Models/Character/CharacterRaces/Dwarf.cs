using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces
{
    public class Dwarf : ICharacterRace
    {

        private StatisticsManager _statisticsManager;
        private string _description;
        public string RaceName { get; set; } = "Dwarf";
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "Krasnolud to niska ale zarazem bardzo silna rasa, jest niezrównany w posługiwaniu się młotem oraz toporem w walce, mimo że dość szybko wpada w złość co może wskazywać na brak rozwagi, jednak to tylko pozory bo za awanturniczą naturą ukrywa się duża inteligencja, niezrównany górnik oraz znawca wszelakich kruszców.";
            }
        }

    }
}
