
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public interface ICharacterAction
    {
        string Name { get; }

        void Execute(PlayerCharacter player, IEnemy enemy);
    }
}
