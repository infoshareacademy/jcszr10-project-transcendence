using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Builders;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.DTOs;

var playerCharacterDTO = new PlayerCharacterDTO()
{
    Id = 1,
    Name = "Test",
    Race = "Human",
    CharacterClass = GlobalEnums.ClassType.Monk,
    Level = 1,
    Experience = 0,
    Health = 100,
    MaxHealth = 100,
    Agility = 10,
    Strength = 10,
    Intelect = 10,
    Luck = 10,
    FinishedDungeonIndex = 1,
    RaceId = 1,
    ClassId = 1,
    UserId = 1,
    MainHandWeapon = new ItemDto() { Id = 4, Name = "Mieczyk 1h", Description = "asd", ItemType = GlobalEnums.ItemType.Weapon, Damage = 100,  },
    OffHandWeapon = new ItemDto() { Id = 2, Name = "Mieczyk 2h", Description = "asdd", ItemType = GlobalEnums.ItemType.Weapon, Damage = 100, },
    Jewelery = new List<ItemDto> { new ItemDto() {Id = 22, Description = " zloty", Name = "Pierscien", Intelect = 5, ItemType = GlobalEnums.ItemType.Jewelery } },
    Inventory = new List<ItemDto> { new ItemDto() { Id = 222, Description = " zloty", Name = "Pierscien", Intelect = 5, ItemType = GlobalEnums.ItemType.Jewelery },
    new ItemDto() { Id = 224, Description = " zloty", Name = "Lancuch", Intelect = 5, ItemType = GlobalEnums.ItemType.Jewelery }
    }
};
Console.WriteLine("DTO:");
Console.WriteLine(playerCharacterDTO.ToString());



var characterBuilder = new PlayerCharacterBuilder(playerCharacterDTO);
var director = new Director(characterBuilder);
director.ConstructPlayerCharacter();
PlayerCharacter player = characterBuilder.Build();

Console.WriteLine("Model: ");
Console.WriteLine(player.ToString());


var x = player.ConvertToDto();


Console.WriteLine("DTO after mapping:");
Console.WriteLine(x.ToString());
