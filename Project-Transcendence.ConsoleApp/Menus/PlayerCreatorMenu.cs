using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Services;
using Project_Transcendence.BusinessLogic.Factories;


namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class PlayerCreatorMenu
    {
        public static void Run()
        {
            Console.WriteLine("opis klas");
            Console.WriteLine();
            string[] characterClasses = { "Mnich", "Czarodziej", "Druid", "Wojownik" };
            string[] characterRaces = { "Aasimar", "Krasnolud", "Wysoki Elf", "Ork" };
            string title = "Wybierz swoją klasę!";
            string title2 = "Wybierz rasę!";

            ICharacterClass characterClass = null;
            ICharacterRace characterRace = null;

            Menu menu = new Menu(title, characterClasses);
            Menu menu2 = new Menu(title2, characterRaces);

            Console.Clear();
            Console.WriteLine("Podaj swoje imie! ");
            string name = Console.ReadLine();

            switch (menu.Run())
            {
                case 0:
                    characterClass = new Monk();
                    break;

                case 1:
                    characterClass = new Wizard();
                    break;

                case 2:
                    characterClass = new Rogue();
                    break;

                case 3:
                    characterClass = new Warrior();
                    break;
            }

            switch (menu2.Run())
            {
                case 0:
                    characterRace = new Aasimar();
                    break;

                case 1:
                    characterRace = new Human();
                    break;

                case 2:
                    characterRace = new HighElf();
                    break;

                case 3:
                    characterRace = new Dwarf();
                    break;
            }

            PlayerFactory playerFactory = new PlayerFactory();

            var player1 = playerFactory.Create(name, characterRace, characterClass);

            Console.WriteLine(player1.StatisticsManager.Strength);
            Console.WriteLine(player1.StatisticsManager.Intelect);
            Console.WriteLine(player1.StatisticsManager.Luck);
            Console.WriteLine(player1.StatisticsManager.Agility);
            if(player1 is BasicCharacter player)
            {
                Console.WriteLine(player.HealthManager.Health);
            }

            Console.WriteLine("Wcisnij przycisk by zacząć przygodę!");
            Console.ReadKey(true);
            ChoseSpellMenu menu1 = new ChoseSpellMenu(player1);
            menu1.ChoseAbility();
        }
    }
}
