using Project_Transcendence.ConsoleApp.Menus;

namespace Project_Transcendence.ConsoleApp
{
    public class Game
    {

        public void Start()
        {
            //LoadingMenu.Run(AsciiArt.loading);
            Console.Title = "Transcendence";
            StartingMenu.Run();

        }
    }
}
