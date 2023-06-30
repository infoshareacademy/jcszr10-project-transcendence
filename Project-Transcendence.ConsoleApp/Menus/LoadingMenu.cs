using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class LoadingMenu
    {
        public static void Run(string[] frames)
        {
            for (int i = 0; i <5; i++)
            {
                foreach (string frame in frames)
                {
                    Console.Clear();
                    Console.Write(frame);
                    Thread.Sleep(10);
                }
            }
        }

    }
}
