using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public class Wizard : ICharacterClass
    {
        private string _description = "Czarodziej to utalentowany magiczny mistrz, który walczy z siłą zaklęć i eliksirów. Zawodowy manipulator energii magicznej, czarodziej zdobywa wiedzę i umiejętności, które pozwalają mu rzucać potężne czary i używać magii w różnorodny sposób";

        public List<IAbility> Abilities { get; set; }
        public string Description { get; set; }
        public string ClassName { get; set; } = "Wizard";
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
