
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses.Resources;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public class Monk : ICharacterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ability> Abilities { get; set; }
        public string Description { get; set; }
        public Resource Resource { get; set; }
    }
}
