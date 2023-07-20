
namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class HighElf : ICharacterRace
    {

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
        public string GetCharacterRaceName()
        {
            return nameof(HighElf);
        }
    }
}
