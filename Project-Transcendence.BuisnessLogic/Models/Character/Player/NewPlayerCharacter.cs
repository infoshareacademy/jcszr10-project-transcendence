
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class NewPlayerCharacter
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public int Id { get; set; }
        public string CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<int> Inventory { get; set; }
        public List<int> Weapons { get; set; }
        public List<int> Jewelery { get; set; }
        public int Health { get; set; }
        public int Agility { get; set; }
        public int Intelect { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }

        public NewPlayerCharacter(string name, string race, int level, int id, string characterClass, int experience, int health, int agility, int intelect, int strength, int luck, List<int> inventory = null, List<int> weapons = null, List<int> jewelery = null)
        {
            Name = name;
            Race = race;
            Level = level;
            Id = id;
            CharacterClass = characterClass;
            Experience = experience;
            Inventory = inventory;
            Weapons = weapons;
            Jewelery = jewelery;
            Health = health;
            Agility = agility;
            Intelect = intelect;
            Strength = strength;
            Luck = luck;
        }

    }
}
