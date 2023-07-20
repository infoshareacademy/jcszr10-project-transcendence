using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    public class Potion : Item, IPotion
    {
        public Potion(int healing) : base(" ", " ", 0, 0, 0, 0)
        {
            Healing = healing;
        }
        public int Healing { get; set; }
    }
}
