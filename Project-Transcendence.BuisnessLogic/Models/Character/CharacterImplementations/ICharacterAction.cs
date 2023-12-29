namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations
{
    public interface ICharacterAction
    {
        string Name { get; }

        void Execute(IBasicCharacter performer, IBasicCharacter target);
    }
}
