using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
using Project_Transcendence.BuisnessLogic.Models.Converters;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;
using Project_Transcendence_Database.Entities;
using System.Text;
using static Project_Transcendence.BuisnessLogic.Globals.GlobalEnums;

namespace Project_Transcendence.BuisnessLogic.Models.DTOs
{
    public class PlayerCharacterDTO : IEntityConvertible<PlayerCharacter>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public ICharacterRace Race { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int ResourceAmount { get; set; }
        public int MaxResourceAmount { get; set; }
        public string ResourceName { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelect { get; set; }
        public int Luck { get; set; }
        public IItem Weapon { get; set; }
        public List<IItem> Jewelery { get; set; }
        public List<IItem> Inventory { get; set; }
        public int Expirience { get; set; }
        public int UserId { get; set; }
        public ICharacterClass CharacterClass { get; set; }

        public PlayerCharacter ConvertToEntity() => new()
        {

        };

        public PlayerCharacterDTO ConvertFromEntity(PlayerCharacter entity) => new()
        {
   
        };

    }
}
