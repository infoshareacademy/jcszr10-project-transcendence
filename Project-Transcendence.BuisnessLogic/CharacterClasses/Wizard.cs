using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.CharacterClasses
{
    public class Wizard : ICharacterClass
    {
        private string _description = "Czarodziej to utalentowany magiczny mistrz, który walczy z siłą zaklęć i eliksirów. Zawodowy manipulator energii magicznej, czarodziej zdobywa wiedzę i umiejętności, które pozwalają mu rzucać potężne czary i używać magii w różnorodny sposób";
        public Wizard()
        {
            Description = _description;
            ClassName = "Czarodziej";
            Abilities = new List<IAbility>()
            {
                new Ability("Ognisty pocisk", "Ciskasz garścią ognia w istotę w zasięgu czaru.", 0, 20),
                new Ability("Piekielna reprymenda", "Istotę spowijają ognie piekielne.", 0, 35),
                new Ability("Magiczny pocisk", "Wywołujesz trzy świetliste strzałki stworzone z magicznej energii.", 0, 50),
                new Ability("Leczenie ran", "Odzyskujesz punkty wytrzymałości", 40, 0)
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
