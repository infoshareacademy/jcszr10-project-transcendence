using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class StartingMenu
    {

        public static void Run()
        {
            Console.WriteLine("Starting the game!");
            string prompt = AsciiArt.headerArt;
            string[] options = { "Play", "About", "Exit" };
            Menu StartingMenu = new Menu(prompt, options);
            int selectedIndex = StartingMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MainMenu.Run();
                    break;

                case 1:
                    AboutInfoMenu.Run();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

    }
}
