using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character
{
    public interface IBasicCharacter
    {
        public string Name { get; set; }
        public ICharacterRace Race { get; set; }
        public int Level { get; set; }

        public void LevelUp();
      
    }
}
