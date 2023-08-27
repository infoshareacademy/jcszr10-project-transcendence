using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses
{
    public class Monk : ICharacterClass
    {
        private string _description = "Mnich to mistrz sztuk walki, który harmonizuje ciało, umysł i duszę. Poprzez długie lata treningu i medytacji, mnich osiąga doskonałość w technikach walki wręcz i opanowuje sztuki obronne. Jego umiejętności fizyczne są wspierane przez głębokie duchowe przekonania, co pozwala mu opanować techniki uzdrawiania, koncentrację umysłu i kontrolę nad energią życiową. Jako pustelnicy i obrońcy sprawiedliwości, mnisi emanują spokojem, mądrością i pokorą, czyniąc ich niezwykle szanowanymi i inspirującymi postaciami.";

        public List<IAbility> Abilities { get; set; }
        public string Description { get; set; }
        public string ClassName { get; set; } = "Monk";
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
