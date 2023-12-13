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

