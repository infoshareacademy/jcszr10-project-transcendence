using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Items
{
    public class Weapon : IItem, IWeapon
    {
        public Weapon() { }
        public Weapon(string name, string description, int damage)
        {
            Name = name;
            Description = description;
            Damage = damage;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
    }
}
