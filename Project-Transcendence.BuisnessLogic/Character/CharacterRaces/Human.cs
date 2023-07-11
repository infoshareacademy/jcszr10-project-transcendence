using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterRaces
{
    public class Human : ICharacterRace
    {
        //TODO: Design your chosen race #3.
        public string Description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = "Człowiek to dość pospolita rasa, żyje krótko i jest dość słaby w porównaniu do innych inteligentnych gatunków, mimo swoich ograniczeń posiada zdolność szybkiego dostosowania się do zaistniałych warunków, łatwość uczenia się i zdobywania umiejętności, dają mu możliwość wcielania się w dowolną klasę.";
            }
        }

        public string GetCharacterRaceName()
        {
            return nameof(Human);
        }
    }
}
