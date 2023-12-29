using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses.Resources;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public class Monk : ICharacterClass
    {
        public List<IAbility> Abilities { get; set; } = ClassAbilities._MonkAbilities;
        public string Name { get; set; } = "Monk";
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceManager Resource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
