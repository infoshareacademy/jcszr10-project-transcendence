using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public interface IEnemyCharacterBuilder
    {
        public void SetId();
        public void SetName();
        public void SetLevel();
        public void SetRace();
        public void SetAbilities();
        public void SetInventory();

        Enemy Build();
    }
}
