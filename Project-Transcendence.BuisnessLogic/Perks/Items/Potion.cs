using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    public class Potion : IItem, IPotion
    {
        public Potion()
        {

        }
        public Potion(string name, string description, int healing)
        {
            Name = name;
            Description = description;
            Healing = healing;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Healing { get; set; }
    }
}
