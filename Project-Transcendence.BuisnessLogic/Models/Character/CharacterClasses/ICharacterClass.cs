using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public interface ICharacterClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public List<IAbility> Abilities { get; set; }
        public string Description { get; set; }
    }
}
