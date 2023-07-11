using Project_Transcendence.ConsoleApp.Perks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public interface ICharacterRace
    {
        public string Description { get; set; }
        public string GetCharacterRaceName();

    }
}
