using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.ConsoleApp.CharacterClasses;
using Project_Transcendence.ConsoleApp.CharacterRaces;
using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Character
{
    public class Player : Character, IPlayer
    {
        public ICharacterClass CharacterClass { get; set; }

        public int Experience { get; set; }

        public List<IItem> Inventory  { get; set; }
        public List<IItem> Gear { get; set; }
        public List<IItem> Weapons { get; set; }
        public List<IItem> Jewelery { get; set; }

        public Player(string name, ICharacterRace race, ICharacterClass characterClass, int startingHealth, int startingExp, int level)
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
            return $"Imie: {Name} Rasa: {Race} Klasa: {CharacterClass} Poziom: {Level} Punkty doświadczenia: {Experience}";
        }
    }
}
