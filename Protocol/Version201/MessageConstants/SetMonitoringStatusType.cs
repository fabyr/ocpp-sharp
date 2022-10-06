using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class SetMonitoringStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(SetMonitoringStatusType.Accepted)]
			Accepted,
            [StringValue(SetMonitoringStatusType.UnknownComponent)]
			UnknownComponent,
            [StringValue(SetMonitoringStatusType.UnknownVariable)]
			UnknownVariable,
            [StringValue(SetMonitoringStatusType.UnsupportedMonitorType)]
			UnsupportedMonitorType,
            [StringValue(SetMonitoringStatusType.Rejected)]
			Rejected,
            [StringValue(SetMonitoringStatusType.Duplicate)]
			Duplicate
        }
        public const string Accepted = "Accepted";
        public const string UnknownComponent = "UnknownComponent";
        public const string UnknownVariable = "UnknownVariable";
        public const string UnsupportedMonitorType = "UnsupportedMonitorType";
        public const string Rejected = "Rejected";
        public const string Duplicate = "Duplicate";
    }
}