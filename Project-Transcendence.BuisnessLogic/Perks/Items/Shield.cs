using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    internal class Shield : Item, IShield
    {
        public Shield(int defense) : base(" ", " ", 0, 0, 0, 0)
        {
            Defense = defense;
        }
        public int Defense { get; set; }
    }
}
