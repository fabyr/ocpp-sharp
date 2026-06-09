using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class AttributeType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(AttributeType.Actual)]
        Actual,

        [StringValue(AttributeType.Target)]
        Target,

        [StringValue(AttributeType.MinSet)]
        MinSet,

        [StringValue(AttributeType.MaxSet)]
        MaxSet
    }

    public const string Actual = "Actual";
    public const string Target = "Target";
    public const string MinSet = "MinSet";
    public const string MaxSet = "MaxSet";
}
