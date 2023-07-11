using Project_Transcendence.BuisnessLogic.Perks.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Character.CharacterClasses
{
    public class Thief : ICharacterClass
    {
        private string _description = "Złodziej to mistrz podstępu, cichy, szybki, potrafi stać się niewidoczny co daje mu przewagę nad niczym nie spodziewającą się ofiarą,\r\nposługuje się lekkim orężem które nie spowalnia jego ruchów, największy atut to spryt i zręczność, dzięki czemu skutecznie pokonuje przeszkody bez używania siły ale\r\nw bezpośrednim starciu jest niemal bezbronny, dlatego zawsze atakuje skrycie.\r\n";
        public Thief()
        {
            Description = _description;
            ClassName = "Złodziej";
            Abilities = new List<IAbility>()
            {
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability()
            };
        }

        public List<IAbility> Abilities { get; set; }

        public string Description { get; set; }
        public string ClassName { get; set; }

        public void DisplayAbilities()
        {
            foreach (var item in Abilities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
