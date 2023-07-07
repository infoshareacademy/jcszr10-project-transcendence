using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.ConsoleApp.CharacterClasses;
using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Character
{
    public class Player : IPlayer
    {
        public ICharacterClass CharacterClass { get; set; }

        public int Experience { get; set; }

        public List<IItem> Inventory  { get; set; }
        public List<IItem> Gear { get; set; }
        public List<IItem> Weapons { get; set; }
        public List<IItem> Jewelery { get; set; }

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
    }
}
