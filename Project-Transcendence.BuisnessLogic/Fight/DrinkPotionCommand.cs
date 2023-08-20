using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BusinessLogic.Fight
{
    public class DrinkPotionCommand : ICommand
    {
        private PlayerCharacter _player;
        private Potion _potion;
        
        public DrinkPotionCommand(PlayerCharacter player, Potion potion) 
        {
            _player = player;
            _potion = potion;
        }
        public void Execute()
        {
            _player.HealthManager.DecreaseHealth(_potion.Healing);
        }
    }
}
