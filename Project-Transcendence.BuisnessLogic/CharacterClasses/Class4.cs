using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.CharacterClasses
{
    public class Class4 : ICharacterClass
    {
        // TODO: Design your chosen class #4
        public List<Ability> Abilities => throw new NotImplementedException();

        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ClassName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        List<IAbility> ICharacterClass.Abilities => throw new NotImplementedException();

        public void DisplayAbilities()
        {
            throw new NotImplementedException();
        }
    }
}
