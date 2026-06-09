using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class DeleteCertificateStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(DeleteCertificateStatusType.Accepted)]
        Accepted,

        [StringValue(DeleteCertificateStatusType.Failed)]
        Failed,

        [StringValue(DeleteCertificateStatusType.NotFound)]
        NotFound
    }

    public const string Accepted = "Accepted";
    public const string Failed = "Failed";
    public const string NotFound = "NotFound";
}
