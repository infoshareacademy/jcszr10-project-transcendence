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
           // RunLoadingScreen();
            Console.Title = "Transcendence";
            RunStartingMenu();
            PlayerCreatorMenu.Run();
        }

        private void RunStartingMenu()
        {
            StartingMenu.Run();
        }

        private void RunLoadingScreen()
        {
            LoadingMenu.Run(AsciiArt.loading);
        }

    }
}
