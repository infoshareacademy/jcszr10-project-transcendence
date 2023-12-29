using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses.Resources;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public interface ICharacterClass
    {
        public int Id { get; set; }
        public List<IAbility> Abilities { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ResourceManager Resource { get; set; }
    }
}
