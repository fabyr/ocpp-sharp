using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct EventData
{
    public static readonly EventData Empty = new();

    [JsonProperty("eventId")]
    public long EventId { get; set; }

    [JsonProperty("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("trigger")]
    public EventTriggerType.Enum Trigger { get; set; }

    [JsonProperty("cause")]
    public long? Cause { get; set; }

    [JsonProperty("actualValue")]
    public string ActualValue { get; set; }

    [JsonProperty("techCode")]
    public string? TechCode { get; set; }

    [JsonProperty("techInfo")]
    public string? TechInfo { get; set; }

    [JsonProperty("cleared")]
    public bool? Cleared { get; set; }

    [JsonProperty("transactionId")]
    public CiString? TransactionId { get; set; }

    [JsonProperty("variableMonitoringId")]
    public long VariableMonitoringId { get; set; }

    [JsonProperty("eventNotificationType")]
    public EventNotificationType.Enum EventNotificationType { get; set; }

    [JsonProperty("component")]
    public Component Component { get; set; }

    [JsonProperty("variable")]
    public Variable Variable { get; set; }
}
