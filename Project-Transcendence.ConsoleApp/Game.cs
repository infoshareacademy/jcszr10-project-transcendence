using Newtonsoft.Json;
using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence.BuisnessLogic.Services;
using Project_Transcendence.ConsoleApp.Menus;

namespace Project_Transcendence.ConsoleApp
{
    public class Game
    {
        public void Start()
        {

            PlayerService playerService = new PlayerService();



            string json = File.ReadAllText(JsonString.WeaponJsonString);
            var deserializedWeaponList = JsonConvert.DeserializeObject<List<Weapon>>(json);
            ItemList.Weapons = deserializedWeaponList;

            string json1 = File.ReadAllText(JsonString.JeweleryJsonString);
            var deserializedJeweleryList = JsonConvert.DeserializeObject<List<Jewelery>>(json1);
            ItemList.Jeweleries = deserializedJeweleryList;

            foreach (var item in EnemyContainer.Enemies)
            {
                EnemyInitializerService enemyInitializer = new(item);
                enemyInitializer.Initialize();
            }
            foreach (var item in DungeonContainer.Dungeons)
            {
                DungeonInitializerService dungeonInitializer = new(item);
                dungeonInitializer.Initialize();
            }

            var x = playerService.LoadPlayer();

            PlayerList.PlayerCharacters.Add(x);

            //LoadingMenu.Run(AsciiArt.loading);
            Console.Title = "Transcendence";
            StartingMenu.Run();

        }
    }
}
