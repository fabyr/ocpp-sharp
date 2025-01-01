using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class InstallCertificateUseType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(InstallCertificateUseType.V2GRootCertificate)]
        V2GRootCertificate,

        [StringValue(InstallCertificateUseType.MORootCertificate)]
        MORootCertificate,

        [StringValue(InstallCertificateUseType.CSMSRootCertificate)]
        CSMSRootCertificate,

        [StringValue(InstallCertificateUseType.ManufacturerRootCertificate)]
        ManufacturerRootCertificate
    }

    public const string V2GRootCertificate = "V2GRootCertificate";
    public const string MORootCertificate = "MORootCertificate";
    public const string CSMSRootCertificate = "CSMSRootCertificate";
    public const string ManufacturerRootCertificate = "ManufacturerRootCertificate";
}
