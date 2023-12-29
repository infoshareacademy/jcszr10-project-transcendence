namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.Actions
{
    public interface IActionDirector
    {

        void PerformAction(IBasicCharacter performer, IBasicCharacter target, ICharacterAction action);

    }
}
