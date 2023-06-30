using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class AboutInfoMenu
    {
        public static void Run()
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
            StartingMenu.Run();
        }
    }
}
