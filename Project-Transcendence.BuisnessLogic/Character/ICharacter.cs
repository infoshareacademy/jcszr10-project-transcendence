using Project_Transcendence.ConsoleApp.CharacterRaces;
using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.ConsoleApp.Character
{
    internal interface ICharacter
    {
        public string Name { get; set; }
        public ICharacterRace Race { get; set; }
        public int Level { get; set; }

        public void LevelUp();
      
    }
}
