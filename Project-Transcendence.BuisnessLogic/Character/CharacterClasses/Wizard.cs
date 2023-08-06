using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
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
                new Ability("Piekielna reprymenda", "Istotę spowijają ognie piekielne.", 0, 25),
                new Ability("Magiczny pocisk", "Wywołujesz trzy świetliste strzałki stworzone z magicznej energii.", 0, 45),
                new Ability("Leczenie ran", "Odzyskujesz punkty wytrzymałości", 40, 0),
                new Ability("Atak z broni", Weapons[0].Damage)
            };
            Weapons = new List<IWeapon>()
            {
                new Weapon(30, "Miecz długi"),
                new Weapon(20, "Strzałka")
            };
            Jewelery = new List<Jewelery>()
            {
                new Jewelery("Pierścień zmierzchu"," ", 1 , 1 , 1 ,1)
            };
        }

        public List<IAbility> Abilities { get; set; }
        public List<IWeapon> Weapons { get; set; }

        public string Description { get; set; }
        public string ClassName { get; set; }

        public List<Jewelery> Jewelery { get; }

        public void DisplayAbilities()
        {
            foreach (var item in Abilities)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayWeapon()
        {
            foreach (var item in Weapons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
