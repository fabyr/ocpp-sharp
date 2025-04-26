using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct StatusInfo
{
    public static readonly StatusInfo Empty = new();

    [JsonPropertyName("reasonCode")]
    public CiString ReasonCode { get; set; }

    [JsonPropertyName("additionalInfo")]
    public string? AdditionalInfo { get; set; }
}
