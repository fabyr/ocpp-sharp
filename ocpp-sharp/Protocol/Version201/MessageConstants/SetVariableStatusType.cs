using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class SetVariableStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(SetVariableStatusType.Accepted)]
        Accepted,

        [StringValue(SetVariableStatusType.Rejected)]
        Rejected,

        [StringValue(SetVariableStatusType.UnknownComponent)]
        UnknownComponent,

        [StringValue(SetVariableStatusType.UnknownVariable)]
        UnknownVariable,

        [StringValue(SetVariableStatusType.NotSupportedAttributeType)]
        NotSupportedAttributeType,

        [StringValue(SetVariableStatusType.RebootRequired)]
        RebootRequired
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string UnknownComponent = "UnknownComponent";
    public const string UnknownVariable = "UnknownVariable";
    public const string NotSupportedAttributeType = "NotSupportedAttributeType";
    public const string RebootRequired = "RebootRequired";
}
