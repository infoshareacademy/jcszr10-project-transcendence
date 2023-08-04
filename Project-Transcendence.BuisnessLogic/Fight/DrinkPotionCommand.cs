using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class DrinkPotionCommand : ICommand
    {
        private BasicPlayer _player;
        private Potion _potion;
        
        public DrinkPotionCommand(BasicPlayer player, Potion potion) 
        {
            _player = player;
            _potion = potion;
        }
        public void Execute()
        {
            _player.TakeHealth(_potion.Healing);
        }
    }
}
