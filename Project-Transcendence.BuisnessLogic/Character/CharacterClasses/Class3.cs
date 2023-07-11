using Project_Transcendence.BuisnessLogic.Perks.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
{
    public class Class3 : ICharacterClass
    {
        //TODO: Design your chosen class #3
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
