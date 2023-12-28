using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class ActionService : IActionService
    {


        public ActionService()
        {
            
        }

        public ICharacterAction ChooseActionForEnemy(EnemyCharacter enemy)
        {

            return new AttackAction();

        }

        public ICharacterAction ChooseActionForPlayer(PlayerCharacter player)
        {

  

            return null; 
        }
    }
}
