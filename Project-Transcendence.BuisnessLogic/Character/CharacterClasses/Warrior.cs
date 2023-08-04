using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
{
    public class Warrior : ICharacterClass
    {
        private string _description = "Wojownik to niepowstrzymana siła, wszystkie problemy rozwiązuje przemocą, niezrównany w posługiwaniu się bronią białą a jego wytrzymałość na ciosy jest wręcz legendarna, swoją inteligencje wykorzystuje do uczenia się nowych technik fechtunku i metod w pokonywaniu wrogów, nie jest mu obce żadne pole bitwy.";
        public Warrior()
        {
            Description = _description;
            ClassName = "Wojownik";
            Abilities = new List<IAbility>()
            {
                new Ability("Znak Łowcy", "Oznaczasz istotę którą widzisz i zadajesz jej magiczne obrażenia", 0, 20),
                new Ability("Leczenie ran", "Odzyskujesz punkty wytrzymałości", 40, 0),
                new Ability("Kordon strzał", "Rozmieszczasz 4 sztuki niemagicznej amunicji, które uderzają ze zdwojoną siłą", 0, 40),
                new Ability("Alarm", "Ogłuszasz przeciwnika", 0, 15)
            };
            Weapons = new List<IWeapon>()
            {
                new Weapon(35, "Miecz dwuręczny"),
                new Weapon(20, "Kusza")
            };
            Jewelery = new List<Jewelery>()
            {
                new Jewelery("Sygnet"," ", 1 , 1 , 1 ,1)
            };
        }

        public List<IAbility> Abilities { get; set; }
        public List<IWeapon> Weapons { get; set; }
        public List<Jewelery> Jewelery { get; }

        public string Description { get; set; }
        public string ClassName { get; set; }

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
