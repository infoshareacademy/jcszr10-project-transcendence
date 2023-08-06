using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Dwarf : ICharacterRace
    {

        private StatisticsManager _statisticsManager;
        private string _description;
        public Dwarf()
        {
            _statisticsManager = new StatisticsManager(0, 0, 5, 0);
        }

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
        public string RaceName { get; set; } = "Dwarf";

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
            return "Dwarf";
        }
    }
}
