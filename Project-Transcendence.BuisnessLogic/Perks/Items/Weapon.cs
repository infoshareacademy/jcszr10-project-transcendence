using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    public class Weapon : Item, IWeapon
    {
        public Weapon(int damage) : base(" "," ", 0, 0, 0, 0 )
        {
            Damage = damage;
        }

        public int Damage { get; set; }
    }
}
