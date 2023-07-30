using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Human : ICharacterRace
    {

        private StatisticsManager _statisticsManager;

        public Human()
        {
            _statisticsManager = new StatisticsManager(5, 0, 0, 0);
        }

        //TODO: Design your chosen race #3.
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = "Człowiek to dość pospolita rasa, żyje krótko i jest dość słaby w porównaniu do innych inteligentnych gatunków, mimo swoich ograniczeń posiada zdolność szybkiego dostosowania się do zaistniałych warunków, łatwość uczenia się i zdobywania umiejętności, dają mu możliwość wcielania się w dowolną klasę.";
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
            return nameof(Human);
        }

        public int GetCharacterStrength()
        {
            throw new NotImplementedException();
        }
    }
}
