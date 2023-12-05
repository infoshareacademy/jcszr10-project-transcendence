
namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces
{
    internal class Human : ICharacterRace
    {
        public int Id { get; set; }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }
    }
}
