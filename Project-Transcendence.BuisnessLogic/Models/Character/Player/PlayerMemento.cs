using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class PlayerMemento
    {
        public string Name { get; }
        public ICharacterRace Race { get; }
        public ICharacterClass CharacterClass { get; }
        public int Level { get; }
        public int Experience { get; }
        public List<Item> Inventory { get; }
        public List<Item> Gear { get; }
        public List<Weapon> Weapons { get; }
        public List<Jewelery> Jewelery { get; }
        public int FinishedDungeonIndex { get; }

        public PlayerMemento(
            string name,
            ICharacterRace race,
            ICharacterClass characterClass,
            int level,
            int experience,
            List<Item> inventory,
            List<Item> gear,
            List<Weapon> weapons,
            List<Jewelery> jewelery,
            int finishedDungeonIndex,
            string raceType)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            Level = level;
            Experience = experience;
            Inventory = new List<Item>(inventory);
            Gear = new List<Item>(gear);
            Weapons = new List<Weapon>(weapons);
            Jewelery = new List<Jewelery>(jewelery);
            FinishedDungeonIndex = finishedDungeonIndex;

            if (raceType == typeof(Aasimar).FullName)
            {
                Race = new Aasimar();
            }
            else if (raceType == typeof(Human).FullName)
            {
                Race = new Human();
            }
            else if (raceType == typeof(Dwarf).FullName)
            {
                Race = new Dwarf();
            }
            else if (raceType == typeof(HighElf).FullName)
            {
                Race = new HighElf();
            }
        }
    }
}
