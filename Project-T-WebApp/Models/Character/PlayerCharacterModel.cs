using Project_T_WebApp.Models.Classes;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_T_WebApp.Models.Character
{
    public class PlayerCharacterModel : BasicCharacterModel, IPlayer
    {
        public int Id { get; set; }
        public ICharacterClass CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<IItem> Inventory { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Jewelery> Jewelery { get; set; }
        public int Expirience { get; set; }
    }
}
