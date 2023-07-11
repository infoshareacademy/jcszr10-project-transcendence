﻿using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.ConsoleApp.Factories;


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


            ICharacterClass _characterClass = null;
            ICharacterRace _characterRace = null;

            Menu menu = new Menu(title, characterClasses);
            Menu menu2 = new Menu(title2, characterRaces);

            Console.Clear();
            Console.WriteLine("Podaj swoje imie! ");
            string name = Console.ReadLine();

            switch (menu.Run())
            {
                case 0:
                    _characterClass = new Monk();
                    break;

                case 1:
                    _characterClass = new Wizard();
                    break;

                case 2:
                    _characterClass = new Thief();
                    break;

                case 3:
                    _characterClass = new Warrior();
                    break;
            }

            switch (menu2.Run())
            {
                case 0:
                    _characterRace = new Aasimar();
                    break;

                case 1:
                    _characterRace = new Human();
                    break;

                case 2:
                    _characterRace = new HighElf();
                    break;

                case 3:
                    _characterRace = new Dwarf();
                    break;
            }

            PlayerFactory playerFactory = new PlayerFactory(name,_characterRace,_characterClass);

            var player1 = playerFactory.Create();

            Console.WriteLine(player1.ToString());

            Console.ReadKey(true);

            MainMenu.Run();

        }
    }
}
