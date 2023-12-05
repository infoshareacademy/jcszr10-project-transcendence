using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Builders;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.DTOs;

/*
 * public class PlayerCharacterDTO : IEntityConvertible<PlayerCharacter>
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public int Id { get; set; }
        public ClassType CharacterClass { get; set; }
        public int Experience { get; set; }
        public List<ItemDto>? Inventory { get; set; }
        public List<ItemDto>? Jewelery { get; set; }
        public ItemDto? MainHandWeapon { get; set; }
        public ItemDto? OffHandWeapon { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Agility { get; set; }
        public int Intelect { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int FinishedDungeonIndex { get; set; }
        public int RaceId { get; set; }
        public int UserId { get; set; }
        public int ClassId { get; set; }
    }
*/

var playerCharacterDTO = new PlayerCharacterDTO()
{
    Id = 1,
    Name = "Test",
    Race = "Human",
    CharacterClass = GlobalEnums.ClassType.Monk,
    Level = 1,
    Experience = 0,
    Health = 100,
    Agility = 10,
    Strength = 10,
    Intelect = 10,
    Luck = 10,
    FinishedDungeonIndex = 1,
    RaceId = 1,
    ClassId = 1,
    UserId = 1,
};

var characterBuilder = new PlayerCharacterBuilder(playerCharacterDTO);
var director = new Director(characterBuilder);
director.ConstructPlayerCharacter();
PlayerCharacter player = characterBuilder.Build();

var x = player.ConvertToDto();

Console.WriteLine(x.ToString());

