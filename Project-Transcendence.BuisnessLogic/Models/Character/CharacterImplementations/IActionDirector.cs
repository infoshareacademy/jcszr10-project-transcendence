namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations
{
    public interface IActionDirector
    {

        void PerformAction(IBasicCharacter performer, ICharacterAction action, IBasicCharacter target);

    }
}
