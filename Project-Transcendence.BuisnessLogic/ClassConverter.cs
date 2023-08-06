using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_Transcendence.BuisnessLogic.Character.CharacterClasses;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic
{
    internal class ClassConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ICharacterRace);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            string classType = jObject["CharacterRaceType"].ToString();

            ICharacterClass classInstance;

            if (classType == typeof(Monk).AssemblyQualifiedName)
            {
                classInstance = new Monk();
            }
            else if (classType == typeof(Thief).AssemblyQualifiedName)
            {
                classInstance = new Thief();
            }
            else if (classType == typeof(Wizard).AssemblyQualifiedName)
            {
                classInstance = new Wizard();
            }
            else if (classType == typeof(Warrior).AssemblyQualifiedName)
            {
                classInstance = new Warrior();
            }
            else
            {
                classInstance = new Monk();
            }

            using (JsonReader objectReader = jObject.CreateReader())
            {
                serializer.Populate(objectReader, classInstance);
            }
            return classInstance;

        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {

            if (value is ICharacterClass characterClass)
            {
                JObject jObject = new JObject();
                jObject.Add("ClassName", JToken.FromObject(characterClass.ClassName));
                jObject.WriteTo(writer);
            }
            else
            {
                throw new ArgumentException("Value must implement ICharacterClass interface");
            }
        }

    }
}
