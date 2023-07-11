using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Perks
{
    public abstract class Item : IItem
    {
        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Item()
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }
   
    }
    
}
