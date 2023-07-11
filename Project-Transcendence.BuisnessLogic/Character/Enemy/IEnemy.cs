using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;
using Project_Transcendence.ConsoleApp.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.Enemy
{
    public interface IEnemy
    {

        public List<IAbility> EnemyAttacks { get; set; }
        public IAbility Attack();
        public List<IItem> ItemsToDrop { get; set; }
        public void GiveItem(Player player);
    }
}
