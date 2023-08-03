using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
{
    public interface ICharacterClass
    {
        public string ClassName { get; set; }
        public List<IAbility> Abilities { get; }
        public List<IWeapon> Weapons { get; }
        public List<Jewelery> Jewelery { get; }
        public string Description { get; set; }
        public void DisplayAbilities();
        public void DisplayWeapon();
    }
}
