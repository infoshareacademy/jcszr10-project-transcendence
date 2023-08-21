using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;

namespace Project_Transcendence.BuisnessLogic.Converters
{
    public class RaceConverter : JsonConverter
    {
        private const string _race = "CharacterRaceType";

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ICharacterRace);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            string raceType = jObject[_race].ToString();

            ICharacterRace raceInstance;

            raceInstance = raceType switch
            {
                nameof(Aasimar) => new Aasimar(),
                nameof(Dwarf) => new Dwarf(),
                nameof(HighElf) => new HighElf(),
                nameof(Human) => new Human(),
                _ => new Aasimar()
            };

            using var objectReader = jObject.CreateReader();
            serializer.Populate(objectReader, raceInstance);
            return raceInstance;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is ICharacterRace characterRace)
            {
                JObject jObject = new JObject
                {
                    { _race, JToken.FromObject(characterRace.GetType().Name) },
                    { "Description", JToken.FromObject(characterRace.Description) },
                    { "RaceName", JToken.FromObject(characterRace.RaceName) }
                };
                jObject.WriteTo(writer);
            }
            else
            {
                throw new ArgumentException("Value must implement ICharacterRace interface");
            }
        }
    }
}
