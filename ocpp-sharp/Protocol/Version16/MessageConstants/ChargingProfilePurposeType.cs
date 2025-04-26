using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ChargingProfilePurposeType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ChargingProfilePurposeType.ChargePointMaxProfile)]
        ChargePointMaxProfile,

        [StringValue(ChargingProfilePurposeType.TxDefaultProfile)]
        TxDefaultProfile,

        [StringValue(ChargingProfilePurposeType.TxProfile)]
        TxProfile
    }

    public const string ChargePointMaxProfile = "ChargePointMaxProfile";
    public const string TxDefaultProfile = "TxDefaultProfile";
    public const string TxProfile = "TxProfile";
}
