using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Dwarf : ICharacterRace
    {
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = "Krasnolud to niska ale zarazem bardzo silna rasa, jest niezrównany w posługiwaniu się młotem oraz toporem w walce, mimo że dość szybko wpada w złość co może wskazywać na brak rozwagi, jednak to tylko pozory bo za awanturniczą naturą ukrywa się duża inteligencja, niezrównany górnik oraz znawca wszelakich kruszców.";
            }
        }

        public string GetCharacterRaceName()
        {
            return nameof(Dwarf);
        }
    }
}
