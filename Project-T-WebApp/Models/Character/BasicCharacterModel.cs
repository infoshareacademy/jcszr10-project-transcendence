using Project_T_WebApp.Models.Races;

namespace Project_T_WebApp.Models.Character
{
    public abstract class BasicCharacterModel : IHealth, IStatistics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICharacterRace Race { get; set; }
        public int Level { get; set; }
        public string Gender { get; set; }
        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Intelect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Agility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Luck { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
