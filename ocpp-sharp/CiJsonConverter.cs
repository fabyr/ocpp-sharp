using System;
using Newtonsoft.Json;

namespace OcppSharp
{
    /*
    This is needed so Newtonsoft.Json doesn't serialize/deserialize a CiString 
    as "something": { "RawValue": "...", "Value": "..." } but only outputs/can read it as a single string literal "something": "..."
    */
    public class CiJsonConverter : JsonConverter<CiString?>
    {
        public override CiString? ReadJson(JsonReader reader, Type objectType, CiString? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string? s = (string?)reader.Value;
            if(s == null)
                return null;
            return new CiString(s);
        }

        public override void WriteJson(JsonWriter writer, CiString? value, JsonSerializer serializer)
        {
            writer.WriteValue(value?.RawValue);
        }
    }
}