using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses.Resources;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public interface ICharacterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ability> Abilities { get; set; }
        public string Description { get; set; }
        public Resource Resource { get; set; }
    }
}
