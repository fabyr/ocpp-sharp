using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct EVSE
{
    public static readonly EVSE Empty = new();

    [JsonPropertyName("id")]
    public ulong Id { get; set; }

    [JsonPropertyName("connectorId")]
    public long ConnectorId { get; set; }
}
