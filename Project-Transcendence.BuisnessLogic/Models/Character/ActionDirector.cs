namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public class ActionDirector : IActionDirector
    {
        public void PerformAction(IBasicCharacter performer, ICharacterAction action, IBasicCharacter target)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Akcja nie może być null.");
            }

            if (performer == null || target == null)
            {
                throw new ArgumentNullException("Wykonawca i cel akcji nie mogą być null.");
            }
            action.Execute(performer, target);
        }
    }
}
