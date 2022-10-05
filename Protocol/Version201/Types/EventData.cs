using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct EventData
    {
        public static readonly EventData Empty = new EventData();

        public long eventId;
        public DateTime timestamp;
        public EventTriggerType.Enum trigger;
        public long? cause;
        public string actualValue;
        public string? techCode;
        public string? techInfo;
        public bool? cleared;
        public CiString? transactionId;
        public long variableMonitoringId;
        public EventNotificationType.Enum eventNotificationType;
        public Component component;
        public Variable variable;
    }
}