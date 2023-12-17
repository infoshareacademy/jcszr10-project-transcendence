
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public interface ICombatService
    {

        void StartBattle(PlayerCharacter player, EnemyCharacter enemy);

    }
}
