using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Character.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class DrinkPotionCommand : ICommand
    {
        private BasicPlayer _player;
        
        public DrinkPotionCommand(BasicPlayer player) 
        {
        _player = player;
        }
        public void Execute()
        {
            _player.TakeHealth(_player.Potion(50));
        }
    }
}
