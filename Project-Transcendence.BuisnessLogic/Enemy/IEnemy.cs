using Project_Transcendence.ConsoleApp.Character;
using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Enemy
{
    public interface IEnemy
    {

        public List<IAbility> EnemyAttacks { get; set; }
        public IAbility Attack();
        public List<IItem> ItemsToDrop { get; set; }
        public void GiveItem(Player player);
    }
}
