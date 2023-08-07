﻿using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class ClassInfoMenu
    {

        public static void Run()
        {
            Console.WriteLine("Informacje o Mnichu: ");
            Console.WriteLine(new Monk().Description);
            Console.WriteLine();
            Console.WriteLine("Informacje o Czarodzieju: ");
            Console.WriteLine(new Wizard().Description);
            Console.WriteLine();
            Console.WriteLine("Informacje o Złodzieju: ");
            Console.WriteLine(new Thief().Description);
            Console.WriteLine();
            Console.WriteLine("Informacje o Wojowniku: ");
            Console.WriteLine(new Warrior().Description);
            Console.WriteLine("Wcisnij dowolny  przycisk by wrócić");
            Console.ReadKey(true);
            MainMenu.Run();
        }

    }
}
