using Newtonsoft.Json;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
{
    public class Jewelery : Item
    {

        public StatisticsManager StatisticsManager;

        [JsonConstructor]
        public Jewelery(string name, string description,int id, int intelect = 0, int agility = 0, int strength = 0, int luck = 0)
        {
            Name = name;
            Description = description;
            StatisticsManager = new StatisticsManager(intelect, agility, strength, luck);
            Id = id;
        }
    }
}
