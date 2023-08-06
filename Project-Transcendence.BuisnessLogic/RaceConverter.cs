using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic
{
    public class RaceConverter : JsonConverter
    {

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ICharacterRace);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            string raceType = jObject["CharacterRaceType"].ToString();

            ICharacterRace raceInstance;

            if(raceType == typeof(Aasimar).AssemblyQualifiedName)
            {
                raceInstance = new Aasimar();
            }
            else if (raceType == typeof(Human).AssemblyQualifiedName)
            {
                raceInstance= new Human();
            }
            else if (raceType == typeof(Dwarf).AssemblyQualifiedName)
            {
                raceInstance = new Dwarf();
            }
            else if (raceType == typeof(HighElf).AssemblyQualifiedName)
            {
                raceInstance = new HighElf();
            }
            else
            {
                raceInstance = new Aasimar();
            }

            using (JsonReader objectReader = jObject.CreateReader())
            {
                serializer.Populate(objectReader, raceInstance);
            }
            return raceInstance;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is ICharacterRace characterRace)
            {
                JObject jObject = new JObject();
                jObject.Add("CharacterRaceType", JToken.FromObject(characterRace.GetType().AssemblyQualifiedName));
                jObject.Add("Description", JToken.FromObject(characterRace.Description));
                jObject.Add("RaceName", JToken.FromObject(characterRace.RaceName));

                jObject.WriteTo(writer);
            }
            else
            {
                throw new ArgumentException("Value must implement ICharacterRace interface");
            }
        }
    }
}
