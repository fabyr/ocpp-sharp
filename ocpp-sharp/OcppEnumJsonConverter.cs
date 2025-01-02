using Newtonsoft.Json;
using OcppSharp.Protocol;

namespace OcppSharp;

public class OcppEnumJsonConverter : JsonConverter<Enum?>
{
    public override void WriteJson(JsonWriter writer, Enum? value, JsonSerializer serializer)
    {
        string? stringValue = value?.GetAttributeOfType<StringValueAttribute>()?.Text ?? value?.ToString();
        writer.WriteValue(stringValue);
    }

    public override Enum? ReadJson(JsonReader reader, Type objectType, Enum? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        string? existing = (string?)reader.Value;
        if (existing == null || existing == "null")
            return null;
        if (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>))
        {
            objectType = Nullable.GetUnderlyingType(objectType)!;
        }
        var values = Enum.GetValues(objectType).Cast<Enum>();

        // Iterate through all enum values and check if its StringValue matches the JSON
        foreach (Enum value in values)
        {
            // get the string value, if it doesn't have a StringValueAttribute, use the name of it instead (ToString())
            CiString? compare = value.GetAttributeOfType<StringValueAttribute>()?.Text ?? value.ToString();

            if (compare == existing)
            {
                return value;
            }
        }

        throw new FormatException($"Invalid enum value for {objectType.Name}: {reader.Value}");
    }
}
