
namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public interface IActionDirector
    {

        void PerformAction(IBasicCharacter performer, ICharacterAction action, IBasicCharacter target);

    }
}
