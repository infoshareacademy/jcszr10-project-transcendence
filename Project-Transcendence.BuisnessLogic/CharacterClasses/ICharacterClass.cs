using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Transcendence.ConsoleApp.CharacterClasses
{
    public interface ICharacterClass
    {
        public string ClassName { get; set; }
        public List<Ability> Abilities { get; }
        public string Description { get; set; }
        public void DisplayAbilities();
    }
}
