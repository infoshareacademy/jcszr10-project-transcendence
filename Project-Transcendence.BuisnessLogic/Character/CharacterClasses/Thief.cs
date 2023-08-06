using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;


namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
{
    public class Thief : ICharacterClass
    {
        private string _description = "Złodziej to mistrz podstępu, cichy, szybki, potrafi stać się niewidoczny co daje mu przewagę nad niczym nie spodziewającą się ofiarą,\r\nposługuje się lekkim orężem które nie spowalnia jego ruchów, największy atut to spryt i zręczność, dzięki czemu skutecznie pokonuje przeszkody bez używania siły ale\r\nw bezpośrednim starciu jest niemal bezbronny, dlatego zawsze atakuje skrycie.\r\n";
        public Thief()
        {
            Description = _description;
            ClassName = "Złodziej";
            Abilities = new List<IAbility>()
            {
                new Ability("Kuglarstwo", "Tworzysz iluzje zasłony z deszczu iskier, jednocześnie zadając obrażenia", 0, 20),
                new Ability("Magiczna dłoń", "Zadajesz obrażenia", 0, 25),
                new Ability("Fałszywe życie", "Wspomagasz się nekromantyczną namiastką życia", 30, 0),
                new Ability("Gniewne ugodzenie", "Zadajesz obrażenie", 0, 25),
                new Ability("Atak z broni", Weapons[0].Damage)
            };
            Weapons = new List<IWeapon>()
            {
                new Weapon(25, "Miecz krótki"),
                new Weapon(20, "Proca")
            };
            Jewelery = new List<Jewelery>()
            {
                new Jewelery("Pierścień z rubinem"," ", 1 , 1 , 1 ,1)
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
