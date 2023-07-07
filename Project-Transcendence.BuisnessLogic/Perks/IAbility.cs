using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Perks
{
    public interface IAbility
    {
        public int Damage { get; set; }
        public int Healing { get; set; }
        public int Name { get; set; }
    }
}
