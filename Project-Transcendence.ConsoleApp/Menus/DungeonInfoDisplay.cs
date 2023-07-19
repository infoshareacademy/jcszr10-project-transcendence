using Project_Transcendence.BuisnessLogic.Dungeons;
using Project_Transcendence.ConsoleApp.Menus;

namespace Project_Transcendence.ConsoleApp.Dungeons
{
    public static class DungeonInfoDisplay
    {
        public static bool Run(IDungeon dungeon)
        {
            string[] options = { "Wchodzę", "Uciekam" };
            string prompt = $"Widzisz loch typu: {dungeon.DungeonType}, o poziomie trudności {dungeon.DungeonLevel}. Co robisz?!";
            Menu menu = new Menu(prompt, options);
            switch (menu.Run())
            {
                case 0:
                    return true;
                    break;

                case 1:
                    return false;
                    break;
            }
            return false;
        }
    }
}