using Newtonsoft.Json;
using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class PlayerService
    {
        private readonly IPlayerCharacter _player;

        public PlayerService(IPlayerCharacter player)
        {
            _player = player;
        }
        public PlayerService()
        {
            
        }

        public void SavePlayer()
        {
            var playerDto = DtoConverterService.ConvertToDto(_player as PlayerCharacter);

            string serializedPlayer = JsonConvert.SerializeObject(playerDto, Formatting.Indented);
            File.WriteAllText(JsonString.PlayerJsonString, serializedPlayer);
        }

        public IPlayerCharacter LoadPlayer()
        {
            string json1 = File.ReadAllText(JsonString.PlayerJsonString);
            PlayerCharacterDTO deserializedPlayer = JsonConvert.DeserializeObject<PlayerCharacterDTO>(json1);

            return DtoConverterService.ConvertFromDto(deserializedPlayer);
        }
    }
}
