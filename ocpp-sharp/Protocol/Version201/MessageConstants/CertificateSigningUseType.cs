using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class CertificateSigningUseType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(CertificateSigningUseType.ChargingStationCertificate)]
        ChargingStationCertificate,

        [StringValue(CertificateSigningUseType.V2GCertificate)]
        V2GCertificate
    }

    public const string ChargingStationCertificate = "ChargingStationCertificate";
    public const string V2GCertificate = "V2GCertificate";
}
