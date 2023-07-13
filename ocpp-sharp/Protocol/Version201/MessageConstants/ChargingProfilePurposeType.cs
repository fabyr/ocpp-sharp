using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ChargingProfilePurposeType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ChargingProfilePurposeType.ChargingStationExternalConstraints)]
            ChargingStationExternalConstraints,
            [StringValue(ChargingProfilePurposeType.ChargingStationMaxProfile)]
            ChargingStationMaxProfile,
            [StringValue(ChargingProfilePurposeType.TxDefaultProfile)]
            TxDefaultProfile,
            [StringValue(ChargingProfilePurposeType.TxProfile)]
            TxProfile
        }
        public const string ChargingStationExternalConstraints = "ChargingStationExternalConstraints";
        public const string ChargingStationMaxProfile = "ChargingStationMaxProfile";
        public const string TxDefaultProfile = "TxDefaultProfile";
        public const string TxProfile = "TxProfile";
    }
}