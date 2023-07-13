using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class FeatureProfile
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(FeatureProfile.Core)]
			Core,
            [StringValue(FeatureProfile.FirmwareManagement)]
			FirmwareManagement,
            [StringValue(FeatureProfile.LocalAuthListManagement)]
			LocalAuthListManagement,
            [StringValue(FeatureProfile.Reservation)]
			Reservation,
            [StringValue(FeatureProfile.SmartCharging)]
			SmartCharging,
            [StringValue(FeatureProfile.RemoteTrigger)]
			RemoteTrigger
        }

        public const string Core = "Core";
        public const string FirmwareManagement = "FirmwareManagement";
        public const string LocalAuthListManagement = "LocalAuthListManagement";
        public const string Reservation = "Reservation";
        public const string SmartCharging = "SmartCharging";
        public const string RemoteTrigger = "RemoteTrigger";
    }
}