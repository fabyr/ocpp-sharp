using System.Text.Json;
using System.Text.Json.Serialization;

namespace OcppSharp;

/*
This is needed so a CiString doesn't serialize/deserialize to an object.
as "something": { "RawValue": "...", "Value": "..." } but only outputs/can read it as a single string literal "something": "..."
*/
public class CiJsonConverter : JsonConverter<CiString>
{
    public override void Write(Utf8JsonWriter writer, CiString value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.RawValue);
    }

    public override CiString Read(ref Utf8JsonReader reader, Type objectType, JsonSerializerOptions serializer)
    {
        string? s = reader.GetString() ?? throw new FormatException("Invalid null value for CiString");
        return new CiString(s);
    }
}
