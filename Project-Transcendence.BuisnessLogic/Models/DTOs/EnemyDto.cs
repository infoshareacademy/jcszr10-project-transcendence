using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class EnemyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public CharacterRace Race { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<IItem> Inventory { get; set; }
    }
}
