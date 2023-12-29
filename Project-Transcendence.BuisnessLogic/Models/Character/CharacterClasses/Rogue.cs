using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses.Resources;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public class Rogue : ICharacterClass
    {
        public List<IAbility> Abilities { get; set; } = ClassAbilities._RogueAbilities;
        public string Name { get; set; } = "Rogue";
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceManager Resource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
