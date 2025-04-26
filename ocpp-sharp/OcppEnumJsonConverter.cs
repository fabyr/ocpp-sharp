using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using OcppSharp.Protocol;

namespace OcppSharp;

public class OcppEnumJsonConverter : JsonConverterFactory
{
    private JsonNamingPolicy? NamingPolicy { get; }
    private bool AllowIntegerValues { get; }
    private JsonStringEnumConverter BaseConverter { get; }

    public OcppEnumJsonConverter() : this(null, false)
    { }

    public OcppEnumJsonConverter(JsonNamingPolicy? namingPolicy = null, bool allowIntegerValues = false)
    {
        NamingPolicy = namingPolicy;
        AllowIntegerValues = allowIntegerValues;
        BaseConverter = new JsonStringEnumConverter(namingPolicy, allowIntegerValues);
    }

    public override bool CanConvert(Type typeToConvert) => BaseConverter.CanConvert(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Dictionary<string, string> dictionary = typeToConvert
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(field => (field.Name, field.GetCustomAttribute<StringValueAttribute>()?.Text))
            .Where(i => i.Text != null)
            .ToDictionary(p => p.Name, p => p.Text)!;

        if (dictionary.Count > 0)
            return new JsonStringEnumConverter(
                new DictionaryLookupNamingPolicy(dictionary, NamingPolicy),
                AllowIntegerValues
            ).CreateConverter(typeToConvert, options);
        else
            return BaseConverter.CreateConverter(typeToConvert, options);
    }
}

internal class DictionaryLookupNamingPolicy : JsonNamingPolicy
{
    public Dictionary<string, string> Dictionary { get; }
    public JsonNamingPolicy? UnderlyingNamingPolicy { get; }

    public DictionaryLookupNamingPolicy(Dictionary<string, string> dictionary, JsonNamingPolicy? underlyingNamingPolicy)
    {
        Dictionary = dictionary;
        UnderlyingNamingPolicy = underlyingNamingPolicy;
    }

    public override string ConvertName(string name)
        => Dictionary.TryGetValue(name, out string? value)
            ? value
            : (UnderlyingNamingPolicy?.ConvertName(name) ?? name);
}
