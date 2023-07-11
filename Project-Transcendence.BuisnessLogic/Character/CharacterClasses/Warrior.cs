using Project_Transcendence.BuisnessLogic.Perks.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
{
    public class Warrior : ICharacterClass
    {
        private string _description = "Wojownik to niepowstrzymana siła, wszystkie problemy rozwiązuje przemocą, niezrównany w posługiwaniu się bronią białą a jego wytrzymałość na ciosy jest wręcz legendarna, swoją inteligencje wykorzystuje do uczenia się nowych technik fechtunku i metod w pokonywaniu wrogów, nie jest mu obce żadne pole bitwy.";
        public Warrior()
        {
            Description = _description;
            ClassName = "Wojownik";
            Abilities = new List<IAbility>()
            {
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability()
            };
        }

        public List<IAbility> Abilities { get; set; }

        public string Description { get; set; }
        public string ClassName { get; set; }

        public void DisplayAbilities()
        {
            foreach (var item in Abilities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
