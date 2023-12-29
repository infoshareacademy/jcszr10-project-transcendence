using Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
{
    public interface IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Damage { get; set; }
        public int? Armor { get; set; }
        public StatisticsManager Statistics { get; set; }
        public int? Healing { get; set; }
        public ItemType ItemType { get; set; }
    }
}
