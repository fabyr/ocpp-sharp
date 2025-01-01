using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class AuthorizeCertificateStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(AuthorizeCertificateStatusType.Accepted)]
        Accepted,

        [StringValue(AuthorizeCertificateStatusType.SignatureError)]
        SignatureError,

        [StringValue(AuthorizeCertificateStatusType.CertificateExpired)]
        CertificateExpired,

        [StringValue(AuthorizeCertificateStatusType.CertificateRevoked)]
        CertificateRevoked,

        [StringValue(AuthorizeCertificateStatusType.NoCertificateAvailable)]
        NoCertificateAvailable,

        [StringValue(AuthorizeCertificateStatusType.CertChainError)]
        CertChainError,

        [StringValue(AuthorizeCertificateStatusType.ContractCancelled)]
        ContractCancelled
    }

    public const string Accepted = "Accepted";
    public const string SignatureError = "SignatureError";
    public const string CertificateExpired = "CertificateExpired";
    public const string CertificateRevoked = "CertificateRevoked";
    public const string NoCertificateAvailable = "NoCertificateAvailable";
    public const string CertChainError = "CertChainError";
    public const string ContractCancelled = "ContractCancelled";
}
