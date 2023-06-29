using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Transcendence.ConsoleApp.Menus;

namespace Project_Transcendence.ConsoleApp
{
    public class Game
    {
        public void Start()
        {
            RunLoadingScreen();
            Console.Title = "Transcendence";
            RunStartingMenu();
        }

        private void RunStartingMenu()
        {
            Console.WriteLine("Starting the game!");
            string prompt = AsciiArt.headerArt;
            string[] options = { "Play", "About", "Exit" };
            Menu StartingMenu = new Menu(prompt, options);
            int selectedIndex = StartingMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunMainMenu();
                    break;

                case 1:
                    DisplayAboutInfo();
                    break; 

                case 2:
                    ExitGame();
                    break;
            }
        }

        /// <summary>
        /// THis method turns off the console app.
        /// </summary>
        private void ExitGame()
        {
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Console.Clear();
            Console.WriteLine("Gra transcendence jest tworzona przez: ");
            Console.WriteLine("Tech Leader - Piotr Niewczas");
            Console.WriteLine("Scrum Master - Paula Migulska");
            Console.WriteLine("Developer - Piotr Żak");
            Console.WriteLine("Developer - Marek Laskowski");
            Console.WriteLine("Trener - Tymoteusz Micherda");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey(true);
            RunStartingMenu();
        }

        private void RunLoadingScreen()
        {
            LoadingMenu load = new LoadingMenu();
            load.Animate(AsciiArt.loading);
        }

        private void RunMainMenu()
        {
            Console.Clear();
            string prompt = "Hello adventurer what are we going to do today?";
          //  Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (prompt.Length / 2)) + "}", prompt));

            string[] options = { "Create character", "Load Character", "Class info", "Game master", "Back" };
            Menu menuView = new Menu(prompt, options);
            int selectedIndex = menuView.Run();

            switch(selectedIndex)
            {
                case 0:
                    // TODO: Create a character creator menu and system.
                    break; 

                case 1:
                    // TODO: Create a system to load alreade created character.
                    break;

                case 2:
                    // TODO: Create a class info displaying menu.
                    break; 

                case 3:
                    // TODO: Create a admin controls menu.
                    break;
                case 4:
                    Console.Clear();
                    RunStartingMenu();
                    break;
            }



        }
    }
}
