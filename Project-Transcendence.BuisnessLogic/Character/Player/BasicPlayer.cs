using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public class BasicPlayer : BasicCharacter, IPlayer
    {
        public ICharacterClass CharacterClass { get; set; }

        public int Experience { get; set; }

        public List<Item> Inventory { get; set; }
        public List<Item> Gear { get; set; }
        public List<Item> Weapons { get; set; }
        public List<Item> Jewelery { get; set; }

        private StatisticsManager statisticsManager { get; set; }


        public BasicPlayer(string name, ICharacterRace race, ICharacterClass characterClass, int startingHealth, int startingExp, int level)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            Health = startingHealth;
            Level = level;
            Experience = startingExp;
            Inventory = new List<Item>();
            Gear = new List<Item>();
            Weapons = new List<Item>();
            Jewelery = new List<Item>();
            Weapons.Add(new Weapon());
            statisticsManager = new StatisticsManager(10,10,10,10);
        }
        public BasicPlayer()
        {
            
        }

        public int GetIntelect()
        {
            return statisticsManager.Intelect;
        }
        public void IncreaseIntelect(int x)
        {
            statisticsManager.IncreaseIntelect(x);
        }

        public void AddExperience()
        {
            Experience++;
            //TODO: Design exp system 
        }

        public void AddToInventory(Item item)
        {
            Inventory.Add(item);
        }

        public void AddToJewelery(Item item)
        {
            Jewelery.Add(item);
        }

        public void AddToWeapons(Item item)
        {
            Weapons.Add(item);
        }

        public string GetCharacterClass()
        {
            return CharacterClass.GetType().ToString();
        }

        public void RemoveFromInventory(Item item)
        {
            Inventory.Remove(item);
        }

        public void RemoveFromJewelery(Item item)
        {
            Jewelery.Remove(item);
        }

        public void RemoveFromWeapons(Item item)
        {
            Weapons.Remove(item);
        }

        public override string ToString()
        {
            return $"Imie: {Name} Rasa: {Race.GetCharacterRaceName()} Klasa: {CharacterClass.ClassName} Poziom: {Level} Punkty doświadczenia: {Experience}";
        }

        public void LevelUp()
        {
            Level++;
            IncreaseIntelect(5);
        }
    }
}
