using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class CertificateActionType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(CertificateActionType.Install)]
        Install,

        [StringValue(CertificateActionType.Update)]
        Update
    }

    public const string Install = "Install";
    public const string Update = "Update";
}
