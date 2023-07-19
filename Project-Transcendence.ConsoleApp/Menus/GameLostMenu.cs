
namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class GameLostMenu
    {
        public static void Run()
        {
            string[] options = { "Wyjście", "Twórcy", "Menu główne" };
            string prompt = "Przegrałeś, co dalej?";
            Menu menu = new(prompt, options);

            switch (menu.Run())
            {
                case 0:
                    Environment.Exit(0);
                    break;

                case 1:
                    AboutInfoMenu.Run();
                    break;

                case 2:
                    MainMenu.Run();
                    break;
            }
        }
    }
}
