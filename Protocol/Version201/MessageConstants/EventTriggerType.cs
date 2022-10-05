using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class EventTriggerType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(EventTriggerType.Alerting)]
            Alerting,
            [StringValue(EventTriggerType.Delta)]
            Delta,
            [StringValue(EventTriggerType.Periodic)]
            Periodic
        }
        public const string Alerting = "Alerting";
        public const string Delta = "Delta";
        public const string Periodic = "Periodic";
    }
}