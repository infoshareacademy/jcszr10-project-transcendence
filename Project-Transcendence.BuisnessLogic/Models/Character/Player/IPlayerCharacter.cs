using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public interface IPlayerCharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICharacterClass CharacterClass { get; set; }
        public int Experience { get; set; }
        public StatisticsManager StatisticsManager { get; set; }
        public List<IAbility> Abilities { get; set; }
        public int FinishedDungeonIndex { get; set; }
    }
}
