
using Project_Transcendence.BuisnessLogic.Globals;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class PlayerCharacterLoadMenu
    {
        public static void Run()
        {
            List<string> list = new List<string>();

            foreach (var item in PlayerList.PlayerCharacters)
            {
                list.Add(item.Name + " " + item.CharacterClass.ClassName);
            }

            string prompt = "Wybierz postac: ";
            Menu menu = new(prompt,list.ToArray());

            switch (menu.Run())
            {
                case 0:
                    Console.WriteLine(list[0]);
                    break;
            }
        }
    }
}
