using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Perks
{
    internal class Shield : IItem, IShield
    {
        public Shield(string name, string description, int defense) 
        {
            Name = name;
            Description = description;
            Defense = defense;
        }

        public Shield()
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Defense { get; set; }
    }
}
