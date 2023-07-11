
namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class HighElf : ICharacterRace
    {
        private string _description = "Elfy są znanym ze swojego wdzięku magicznym ludem. Elfy wysokie mają bystre umysły i szczycą się znajomością przynajmniej podstaw magii.";
        public HighElf()
        {
            Description = _description;
        }
        public string Description { get; set; }

        public string GetCharacterRaceName()
        {
            return nameof(HighElf);
        }
    }
}
