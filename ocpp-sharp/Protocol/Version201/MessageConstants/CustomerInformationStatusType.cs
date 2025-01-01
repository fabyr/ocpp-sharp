using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class CustomerInformationStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(CustomerInformationStatusType.Accepted)]
        Accepted,

        [StringValue(CustomerInformationStatusType.Rejected)]
        Rejected,

        [StringValue(CustomerInformationStatusType.Invalid)]
        Invalid
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string Invalid = "Invalid";
}
