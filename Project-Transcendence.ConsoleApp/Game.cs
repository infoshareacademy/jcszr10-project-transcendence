using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp
{
    public class Game
    {
        public void Start()
        {
            Console.Title = "Transcendence";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            Console.WriteLine("Starting the game!");
            string prompt = AsciiArt.headerArt;
            string[] options = { "Play", "About", "Exit" };
            MainMenuView mainMenu = new MainMenuView(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    DisplayNextMenu();
                    break;

                case 1:
                    DisplayAboutInfo();
                    break; 

                case 2:
                    ExitGame();
                    break;
            }
        }

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
            Console.WriteLine("Developer Marek Laskowski");
            Console.WriteLine("Trener - Tymoteusz Micherda");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey(true);
            RunMainMenu();
        }

        private void DisplayNextMenu()
        {
            Console.Clear();
            Console.WriteLine("PLACEHOLDER");
            ExitGame();
        }
    }
}
