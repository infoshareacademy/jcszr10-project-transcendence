using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Aasimar : ICharacterRace
    {
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = "Aasimar to rasa istot występujących w wielu światach fantasy, zwykle pochodzących z mieszańców ludzi i istot boskich lub pochodzących bezpośrednio od boskich przodków. Posiadają cechy zarówno ludzkie, jak i boskie, co nadaje im wyjątkowe zdolności i wygląd. ";
            }
        }

        public string GetCharacterRaceName()
        {
            return nameof(Aasimar);
        }
    }
}
