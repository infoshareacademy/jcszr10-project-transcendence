using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
{
    public class Monk : ICharacterClass
    {
        private string _description = "Mnich to mistrz sztuk walki, który harmonizuje ciało, umysł i duszę. Poprzez długie lata treningu i medytacji, mnich osiąga doskonałość w technikach walki wręcz i opanowuje sztuki obronne. Jego umiejętności fizyczne są wspierane przez głębokie duchowe przekonania, co pozwala mu opanować techniki uzdrawiania, koncentrację umysłu i kontrolę nad energią życiową. Jako pustelnicy i obrońcy sprawiedliwości, mnisi emanują spokojem, mądrością i pokorą, czyniąc ich niezwykle szanowanymi i inspirującymi postaciami.";
        public Monk()
        {
            Description = _description;
            ClassName = "Mnich";
            Abilities = new List<IAbility>()
            {
                new Ability("Fists of fury",15),
                new Ability("Touch of Death", 25),
                new Ability("Strike Of A Deadly Mantis", 30),
                new Ability("Inner peace", 0)
            };
        }

        public List<IAbility> Abilities { get; set; }

        public string Description { get; set; }
        public string ClassName { get; set; }

        public void DisplayAbilities()
        {
            foreach (var item in Abilities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
