using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    public interface IStatistics
    {
        public int Intelect { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
    }
}
