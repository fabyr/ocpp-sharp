using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class GenericDeviceModelStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(GenericDeviceModelStatusType.Accepted)]
        Accepted,

        [StringValue(GenericDeviceModelStatusType.Rejected)]
        Rejected,

        [StringValue(GenericDeviceModelStatusType.NotSupported)]
        NotSupported,

        [StringValue(GenericDeviceModelStatusType.EmptyResultSet)]
        EmptyResultSet
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string NotSupported = "NotSupported";
    public const string EmptyResultSet = "EmptyResultSet";
}
