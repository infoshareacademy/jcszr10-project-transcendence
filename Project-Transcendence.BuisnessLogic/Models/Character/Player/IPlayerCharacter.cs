using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public interface IPlayerCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public int FinishedDungeonIndex { get; set; }
        public int Expirience { get; set; }
    }
}
