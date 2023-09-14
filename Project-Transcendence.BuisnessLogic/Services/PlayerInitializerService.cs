using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class PlayerInitializerService : IInitializerService
    {
        private readonly PlayerCharacter _player;

        public PlayerInitializerService(PlayerCharacter player)
        {
            _player = player;
        }

        /// <summary>
        /// This method initializes PlayerCharacter class.
        /// </summary>
        public void Initialize()
        {
            //switch (_player.CharacterClass) // inicjalizacja klasy
            //{
            //    case Monk:
            //        Console.WriteLine("Monk");
            //        _player.Weapons = new();
            //        _player.Jewelery = new();
            //        _player.Inventory = new();
            //        _player.Weapons.Add(ItemList.Weapons.Find(item => item.Id == 0));
            //        _player.Jewelery.Add(ItemList.Jeweleries.Find(item => item.Id == 111));
            //        _player.CharacterClass.Abilities = new List<IAbility>
            //        {
            //            new Ability("Fists of fury",15),
            //            new Ability("Touch of Death", 25),
            //            new Ability("Strike Of A Deadly Mantis", 30),
            //            new Ability("Inner peace", 0),
            //        };
            //        break;

            //    case Warrior:
            //        _player.Weapons = new();
            //        _player.Jewelery = new();
            //        _player.Inventory = new();
            //        _player.Weapons.Add(ItemList.Weapons.Find(item => item.Id == 1));
            //        _player.Jewelery.Add(ItemList.Jeweleries.Find(item => item.Id == 111));
            //        _player.CharacterClass.Abilities = new List<IAbility>
            //        {
            //            new Ability("Znak Łowcy", "Oznaczasz istotę którą widzisz i zadajesz jej magiczne obrażenia", 0, 20),
            //            new Ability("Leczenie ran", "Odzyskujesz punkty wytrzymałości", 40, 0),
            //            new Ability("Kordon strzał", "Rozmieszczasz 4 sztuki niemagicznej amunicji, które uderzają ze zdwojoną siłą", 0, 40),
            //            new Ability("Alarm", "Ogłuszasz przeciwnika", 0, 15),
            //        };

            //        break;

            //    case Wizard:
            //        _player.Weapons = new();
            //        _player.Jewelery = new();
            //        _player.Inventory = new();
            //        _player.Weapons.Add(ItemList.Weapons.Find(item => item.Id == 2));
            //        _player.Jewelery.Add(ItemList.Jeweleries.Find(item => item.Id == 111));
            //        _player.CharacterClass.Abilities = new List<IAbility>
            //        {
            //            new Ability("Ognisty pocisk", "Ciskasz garścią ognia w istotę w zasięgu czaru.", 0, 20),
            //            new Ability("Piekielna reprymenda", "Istotę spowijają ognie piekielne.", 0, 25),
            //            new Ability("Magiczny pocisk", "Wywołujesz trzy świetliste strzałki stworzone z magicznej energii.", 0, 45),
            //            new Ability("Leczenie ran", "Odzyskujesz punkty wytrzymałości", 40, 0)
            //        };
            //        break;

            //    case Rogue:
            //        _player.Weapons = new();
            //        _player.Jewelery = new();
            //        _player.Inventory = new();
            //        _player.Weapons.Add(ItemList.Weapons.Find(item => item.Id == 3));
            //        _player.Jewelery.Add(ItemList.Jeweleries.Find(item => item.Id == 111));
            //        _player.CharacterClass.Abilities = new List<IAbility>
            //        {
            //            new Ability("Znak Łowcy", "Oznaczasz istotę którą widzisz i zadajesz jej magiczne obrażenia", 0, 20),
            //            new Ability("Leczenie ran", "Odzyskujesz punkty wytrzymałości", 40, 0),
            //            new Ability("Kordon strzał", "Rozmieszczasz 4 sztuki niemagicznej amunicji, które uderzają ze zdwojoną siłą", 0, 40),
            //            new Ability("Alarm", "Ogłuszasz przeciwnika", 0, 15),
            //        };
            //        break;

            //    default:
            //        // default value
            //        break;
        }

            //switch (_player.Race) // inicjalizacja rasy
            //{
            //    case Human:
            //        _player.StatisticsManager = new(6, 5, 5, 5);
            //        break;

            //    case Aasimar:
            //        _player.StatisticsManager = new(5, 5, 5, 6);
            //        break;

            //    case Dwarf:
            //        _player.StatisticsManager = new(5, 5, 6, 5);
            //        break;

            //    case HighElf:
            //        _player.StatisticsManager = new(5, 6, 5, 5);
            //        break;
            //    default:
            //        // default value
            //        break;
            //}
        
    }
}
