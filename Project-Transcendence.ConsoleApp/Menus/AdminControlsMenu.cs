
using Newtonsoft.Json;
using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Factories;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public static class AdminControlsMenu
    {
        public static void Run()
        {
            Factory factory = new Factory();
            string prompt = "Admin Panel";
            string[] options = { "Weapon", "Jewelery", "Enemy", "Back" };
            Menu menu = new(prompt, options);

            switch (menu.Run())
            {
                case 0:
                    Console.WriteLine("Weapon => ");
                    Console.WriteLine();
                    Console.WriteLine("Name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Description: ");
                    var description = Console.ReadLine();
                    Console.WriteLine("Damage: ");
                    var damage = Console.ReadLine();
                    Console.WriteLine("Id: ");
                    var id = Console.ReadLine();

                    var weapon = factory.CreateWeapon(name, description, Convert.ToInt32(id), Convert.ToInt32(damage));

                    string filePath = @"H:\\Project_Transcendence\\jcszr10-project-transcendence\\Project-Transcendence.ConsoleApp\\ItemList.json";
                    string json = File.ReadAllText(filePath);
                    var deserializedItemList = JsonConvert.DeserializeObject<List<Weapon>>(json);

                    ItemList.Weapons = deserializedItemList;
                    ItemList.Weapons.Add(weapon as Weapon);

                    string json1 = JsonConvert.SerializeObject(ItemList.Weapons, Formatting.Indented);
                    File.WriteAllText(filePath, json1);
                    AdminControlsMenu.Run();
                    break;

                case 1:
                    Console.WriteLine("Jewelery => ");
                    Console.WriteLine();

                    Console.WriteLine("Name: ");
                    var name1 = Console.ReadLine();
                    Console.WriteLine("Description: ");
                    var description2 = Console.ReadLine();
                    Console.WriteLine("Id: ");
                    var id2 = Console.ReadLine();

                    Console.WriteLine("Intelect value: ");
                    var intelect = Console.ReadLine();
                    Console.WriteLine("Agility value: ");
                    var agility = Console.ReadLine();
                    Console.WriteLine("Strength value: ");
                    var strength = Console.ReadLine();
                    Console.WriteLine("Luck value: ");
                    var luck = Console.ReadLine();

                    var jewelery = factory.CreateJewelery(name1, description2, Convert.ToInt32(id2), Convert.ToInt32(intelect), Convert.ToInt32(agility), Convert.ToInt32(strength), Convert.ToInt32(luck));

                    string filePath1 = @"H:\Project_Transcendence\jcszr10-project-transcendence\Project-Transcendence.ConsoleApp\JeweleryList.json";
                    string json2 = File.ReadAllText(filePath1);
                    var deserializedItemList2 = JsonConvert.DeserializeObject<List<Jewelery>>(json2);

                    ItemList.Jeweleries = deserializedItemList2;
                    ItemList.Jeweleries.Add(jewelery as Jewelery);

                    string json3 = JsonConvert.SerializeObject(ItemList.Jeweleries, Formatting.Indented);
                    File.WriteAllText(filePath1, json3);
                    AdminControlsMenu.Run();
                    break;

                case 2:
                    throw new NotImplementedException();
                    break;

                case 3:
                    MainMenu.Run();
                    break;

            }
        }
    }
}
