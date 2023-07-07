using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.CharacterClasses
{
    internal class Monk : ICharacterClass
    {
        private string _description = "Mnich to mistrz sztuk walki, który harmonizuje ciało, umysł i duszę. Poprzez długie lata treningu i medytacji, mnich osiąga doskonałość w technikach walki wręcz i opanowuje sztuki obronne. Jego umiejętności fizyczne są wspierane przez głębokie duchowe przekonania, co pozwala mu opanować techniki uzdrawiania, koncentrację umysłu i kontrolę nad energią życiową. Jako pustelnicy i obrońcy sprawiedliwości, mnisi emanują spokojem, mądrością i pokorą, czyniąc ich niezwykle szanowanymi i inspirującymi postaciami.";
        public Monk()
        {
            Description = _description;
            Abilities = new List<Ability>()
            { 
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability()
            };
        }

        public List<Ability> Abilities { get; set; }

        public string Description { get; set; }

        public void DisplayAbilities()
        {
            foreach (var item in Abilities)
            {
                Console.WriteLine(item);
            }
        }

        public string GetCharacterClassName()
        {
            return this.GetType().ToString();
        }
    }
}
