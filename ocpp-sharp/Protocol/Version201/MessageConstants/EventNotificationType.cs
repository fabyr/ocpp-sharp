using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class EventNotificationType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(EventNotificationType.HardWiredNotification)]
            HardWiredNotification,
            [StringValue(EventNotificationType.HardWiredMonitor)]
            HardWiredMonitor,
            [StringValue(EventNotificationType.PreconfiguredMonitor)]
            PreconfiguredMonitor,
            [StringValue(EventNotificationType.CustomMonitor)]
            CustomMonitor
        }
        public const string HardWiredNotification = "HardWiredNotification";
        public const string HardWiredMonitor = "HardWiredMonitor";
        public const string PreconfiguredMonitor = "PreconfiguredMonitor";
        public const string CustomMonitor = "CustomMonitor";
    }
}