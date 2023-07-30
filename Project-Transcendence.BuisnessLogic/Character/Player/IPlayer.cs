using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public interface IPlayer
    {
        public ICharacterClass CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Jewelery> Jewelery { get; set; }
        public void AddExperience();
        public string GetCharacterClass();
        public void IncreaseLevel();
        public void LevelUp();
    }
}
