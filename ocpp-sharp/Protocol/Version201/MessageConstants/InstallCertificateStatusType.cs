using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class InstallCertificateStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(InstallCertificateStatusType.Accepted)]
        Accepted,

        [StringValue(InstallCertificateStatusType.Rejected)]
        Rejected,

        [StringValue(InstallCertificateStatusType.Failed)]
        Failed
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string Failed = "Failed";
}
