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
        public string ClassName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayAbilities()
        {
            foreach (var item in Abilities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
