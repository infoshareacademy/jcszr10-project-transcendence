using Project_Transcendence.ConsoleApp.Character;
using Project_Transcendence.ConsoleApp.CharacterClasses;
using Project_Transcendence.ConsoleApp.CharacterRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Factories
{
    public class PlayerFactory
    {
        private string _name;
        private ICharacterRace _race;
        private ICharacterClass _class;
        private int _health;
        private int _experience;
        private int _level;

        public PlayerFactory(string name, ICharacterRace race, ICharacterClass characterClass, int startingHealth = 100, int startingExp = 0, int level = 1)
        {
            _name = name;
            _race = race;
            _class = characterClass;
        }

        public Player Create()
        {
            return new Player(_name,_race,_class,_health,_experience,_level);
        }
    }
}
