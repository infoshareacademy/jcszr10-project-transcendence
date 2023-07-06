using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Perks
{
    public interface IAbility
    {
        int damage { get; set; }
        int healing { get; set; }
    }
}
