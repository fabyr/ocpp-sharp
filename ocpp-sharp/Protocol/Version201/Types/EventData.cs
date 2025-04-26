using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct EventData
{
    public static readonly EventData Empty = new();

    [JsonPropertyName("eventId")]
    public long EventId { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("trigger")]
    public EventTriggerType.Enum Trigger { get; set; }

    [JsonPropertyName("cause")]
    public long? Cause { get; set; }

    [JsonPropertyName("actualValue")]
    public string ActualValue { get; set; }

    [JsonPropertyName("techCode")]
    public string? TechCode { get; set; }

    [JsonPropertyName("techInfo")]
    public string? TechInfo { get; set; }

    [JsonPropertyName("cleared")]
    public bool? Cleared { get; set; }

    [JsonPropertyName("transactionId")]
    public CiString? TransactionId { get; set; }

    [JsonPropertyName("variableMonitoringId")]
    public long VariableMonitoringId { get; set; }

    [JsonPropertyName("eventNotificationType")]
    public EventNotificationType.Enum EventNotificationType { get; set; }

    [JsonPropertyName("component")]
    public Component Component { get; set; }

    [JsonPropertyName("variable")]
    public Variable Variable { get; set; }
}
