using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class GetInstalledCertificateStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(GetInstalledCertificateStatusType.Accepted)]
        Accepted,

        [StringValue(GetInstalledCertificateStatusType.NotFound)]
        NotFound
    }

    public const string Accepted = "Accepted";
    public const string NotFound = "NotFound";
}
