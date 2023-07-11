using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class MainMenu
    {

        public static void Run()
        {
            Console.Clear();
            string prompt = "Hello adventurer what are we going to do today?";
            //  Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (prompt.Length / 2)) + "}", prompt));

            string[] options = { "Create character", "Load Character", "Class info", "Game master", "Back" };
            Menu menuView = new Menu(prompt, options);
            int selectedIndex = menuView.Run();

            switch (selectedIndex)
            {
                case 0:
                    // TODO: Create a character creator menu and system.
                    PlayerCreatorMenu.Run();
                    break;

                case 1:
                    // TODO: Create a system to load already created character.
                    PlayerCharacterLoadMenu.Run();
                    break;

                case 2:
                    ClassInfoMenu.Run();
                    break;

                case 3:
                    // TODO: Create a admin controls menu.
                    AdminControlsMenu.Run();
                    break;

                case 4:
                    Console.Clear();
                    StartingMenu.Run();
                    break;
            }
        }
    }
}
