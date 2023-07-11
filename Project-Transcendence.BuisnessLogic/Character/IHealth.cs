using Project_Transcendence.BuisnessLogic.Perks.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character
{
    public interface IHealth
    {
        public int Health { get; set; }
        public void TakeDamage(IAbility ability);
        public void TakeDamage(int damage);
        public void TakeHealth(IAbility ability);
        public void TakeHealth(int damage);
        public void IncreaseHealth();
    }
}
