namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.States
{
    internal class DoTState : IState
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
    }
}
