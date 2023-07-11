using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public class BasicPlayer : BasicCharacter, IPlayer
    {
        public ICharacterClass CharacterClass { get; set; }

        public int Experience { get; set; }

        public List<IItem> Inventory { get; set; }
        public List<IItem> Gear { get; set; }
        public List<IItem> Weapons { get; set; }
        public List<IItem> Jewelery { get; set; }

        public BasicPlayer(string name, ICharacterRace race, ICharacterClass characterClass, int startingHealth, int startingExp, int level)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            Health = startingHealth;
            Level = level;
            Experience = startingExp;
            Inventory = new List<IItem>();
            Gear = new List<IItem>();
            Weapons = new List<IItem>();
            Jewelery = new List<IItem>();
            Weapons.Add(new Weapon());
        }

        public void AddExperience()
        {
            Experience++;
            //TODO: Design exp system 
        }

        public void AddToInventory(IItem item)
        {
            Inventory.Add(item);
        }

        public void AddToJewelery(IItem item)
        {
            Jewelery.Add(item);
        }

        public void AddToWeapons(IItem item)
        {
            Weapons.Add(item);
        }

        public string GetCharacterClass()
        {
            return CharacterClass.GetType().ToString();
        }

        public void RemoveFromInventory(IItem item)
        {
            Inventory.Remove(item);
        }

        public void RemoveFromJewelery(IItem item)
        {
            Jewelery.Remove(item);
        }

        public void RemoveFromWeapons(IItem item)
        {
            Weapons.Remove(item);
        }

        public override string ToString()
        {
            return $"Imie: {Name} Rasa: {Race.GetCharacterRaceName()} Klasa: {CharacterClass.ClassName} Poziom: {Level} Punkty doświadczenia: {Experience}";
        }
    }
}
