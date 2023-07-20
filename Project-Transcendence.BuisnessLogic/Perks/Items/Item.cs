using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    public abstract class Item : IItem, IStatistics
    {
        public Item(string name, string description, int intelect = 0, int agility = 0, int strength = 0, int luck = 0)
        {
            Name = name;
            Description = description;
            Intelect = intelect;
            Agility = agility;
            Strength = strength;
            Luck = luck;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Intelect { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
    }
}


