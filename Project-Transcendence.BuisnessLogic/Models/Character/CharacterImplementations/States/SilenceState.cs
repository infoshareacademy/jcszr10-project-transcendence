namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.States
{
    public class SilenceState : IState
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; } = "Unable to use abilities";
    }
}
