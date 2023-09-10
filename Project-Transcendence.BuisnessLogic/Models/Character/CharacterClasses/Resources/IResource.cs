namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses.Resources
{
    public interface IResource
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int MaxAmount { get; set; }

    }
}
