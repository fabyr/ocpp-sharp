using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class GetVariableStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(GetVariableStatusType.Accepted)]
        Accepted,

        [StringValue(GetVariableStatusType.Rejected)]
        Rejected,

        [StringValue(GetVariableStatusType.UnknownComponent)]
        UnknownComponent,

        [StringValue(GetVariableStatusType.UnknownVariable)]
        UnknownVariable,

        [StringValue(GetVariableStatusType.NotSupportedAttributeType)]
        NotSupportedAttributeType
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string UnknownComponent = "UnknownComponent";
    public const string UnknownVariable = "UnknownVariable";
    public const string NotSupportedAttributeType = "NotSupportedAttributeType";
}
