using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class GetCertificateIdUseType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(GetCertificateIdUseType.V2GRootCertificate)]
        V2GRootCertificate,

        [StringValue(GetCertificateIdUseType.MORootCertificate)]
        MORootCertificate,

        [StringValue(GetCertificateIdUseType.CSMSRootCertificate)]
        CSMSRootCertificate,

        [StringValue(GetCertificateIdUseType.V2GCertificateChain)]
        V2GCertificateChain,

        [StringValue(GetCertificateIdUseType.ManufacturerRootCertificate)]
        ManufacturerRootCertificate
    }

    public const string V2GRootCertificate = "V2GRootCertificate";
    public const string MORootCertificate = "MORootCertificate";
    public const string CSMSRootCertificate = "CSMSRootCertificate";
    public const string V2GCertificateChain = "V2GCertificateChain";
    public const string ManufacturerRootCertificate = "ManufacturerRootCertificate";
}
