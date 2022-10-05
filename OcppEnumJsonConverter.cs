using System;
using Newtonsoft.Json;
using OcppSharp.Protocol;

namespace OcppSharp
{
    public class OcppEnumJsonConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if(value == null)
            {
                writer.WriteValue((string?)null);
                return;
            }
            System.Enum e = (System.Enum)value;
            StringValueAttribute? attr;
            if((attr = e?.GetAttributeOfType<StringValueAttribute>()) != null)
            {
                writer.WriteValue(attr.Text);
            }
            else
            {
                writer.WriteValue(value?.ToString());
            }
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            string? existing = (string?)reader.Value;
            if(existing == null || existing == "null")
                    return null;
            if(objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                objectType = Nullable.GetUnderlyingType(objectType)!;
            }
            var values = System.Enum.GetValues(objectType).Cast<System.Enum>();
            // Iterate through all enum values and check if its StringValue matches the JSON
            foreach(System.Enum value in values)
            {
                // get the string value, if it doesn't have a StringValueAttribute, use the name of it instead (ToString())
                CiString? compare = value.GetAttributeOfType<StringValueAttribute>()?.Text ?? value.ToString();
                
                if(compare == existing)
                {
                    return value;
                }
            }
            
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetCustomAttributes(typeof(OcppEnumAttribute), true).Length == 1;
        }
    }
}