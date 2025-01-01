using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class UpdateFirmwareStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(UpdateFirmwareStatusType.Accepted)]
        Accepted,

        [StringValue(UpdateFirmwareStatusType.Rejected)]
        Rejected,

        [StringValue(UpdateFirmwareStatusType.AcceptedCanceled)]
        AcceptedCanceled,

        [StringValue(UpdateFirmwareStatusType.InvalidCertificate)]
        InvalidCertificate,

        [StringValue(UpdateFirmwareStatusType.RevokedCertificate)]
        RevokedCertificate
    }

    public const string Accepted = "Accepted";
    public const string Rejected = "Rejected";
    public const string AcceptedCanceled = "AcceptedCanceled";
    public const string InvalidCertificate = "InvalidCertificate";
    public const string RevokedCertificate = "RevokedCertificate";
}
