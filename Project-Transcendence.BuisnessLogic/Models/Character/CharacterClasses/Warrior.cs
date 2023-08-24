using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public class Warrior : ICharacterClass
    {
        private string _description = "Wojownik to niepowstrzymana siła, wszystkie problemy rozwiązuje przemocą, niezrównany w posługiwaniu się bronią białą a jego wytrzymałość na ciosy jest wręcz legendarna, swoją inteligencje wykorzystuje do uczenia się nowych technik fechtunku i metod w pokonywaniu wrogów, nie jest mu obce żadne pole bitwy.";

        public List<IAbility> Abilities { get; set; }
        public string Description { get; set; }
        public string ClassName { get; set; } = "Warrior";
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }       
    }
}
