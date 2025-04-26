using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class CertificateSignedStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(CertificateSignedStatusType.Accepted)]
        Accepted,

        [StringValue(CertificateSignedStatusType.Rejected)]
        Rejected
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
}
