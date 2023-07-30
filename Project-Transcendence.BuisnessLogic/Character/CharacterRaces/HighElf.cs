
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class HighElf : ICharacterRace
    {

        private StatisticsManager _statisticsManager;

        public HighElf()
        {
            _statisticsManager = new StatisticsManager(0, 5, 0, 0);
        }

        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = "Elfy są znanym ze swojego wdzięku magicznym ludem. Elfy wysokie mają bystre umysły i szczycą się znajomością przynajmniej podstaw magii.";
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
            return nameof(HighElf);
        }

        public int GetCharacterStrength()
        {
            throw new NotImplementedException();
        }
    }
}
