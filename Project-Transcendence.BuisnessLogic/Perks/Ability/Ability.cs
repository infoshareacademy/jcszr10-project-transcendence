using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Perks.Ability
{
    public class Ability : IAbility
    {
        public Ability(string name, string description, int healing, int damage)
        {
            Name = name;
            Description = description;
            Healing = healing;
            Damage = damage;
        }
        public Ability()
        {

        }

        public int Damage { get; set; }
        public int Healing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
