
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Aasimar : ICharacterRace
    {
        private StatisticsManager _statisticsManager;

        public Aasimar()
        {
            _statisticsManager = new StatisticsManager(0,0,0,5);
        }

        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = "Aasimar to rasa istot występujących w wielu światach fantasy," +
                    " zwykle pochodzących z mieszańców ludzi i istot boskich lub pochodzących bezpośrednio od boskich przodków." +
                    " Posiadają cechy zarówno ludzkie, jak i boskie, co nadaje im wyjątkowe zdolności i wygląd. ";
            }
        }

        public List<Ability> Abilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
