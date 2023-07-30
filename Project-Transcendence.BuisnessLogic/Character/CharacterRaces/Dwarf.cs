using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Dwarf : ICharacterRace
    {

        private StatisticsManager _statisticsManager;

        public Dwarf()
        {
            _statisticsManager = new StatisticsManager(0, 0, 5, 0);
        }

        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = "Krasnolud to niska ale zarazem bardzo silna rasa, jest niezrównany w posługiwaniu się młotem oraz toporem w walce, mimo że dość szybko wpada w złość co może wskazywać na brak rozwagi, jednak to tylko pozory bo za awanturniczą naturą ukrywa się duża inteligencja, niezrównany górnik oraz znawca wszelakich kruszców.";
            }
        }

        public List<Ability> Abilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetCharacterAgility()
        {
            throw new NotImplementedException();
        }

        public int GetCharacterIntelect()
        {
            throw new NotImplementedException();
        }

        public int GetCharacterLuck()
        {
            throw new NotImplementedException();
        }

        public string GetCharacterRaceName()
        {
            return nameof(Dwarf);
        }

        public int GetCharacterStrength()
        {
            throw new NotImplementedException();
        }
    }
}
