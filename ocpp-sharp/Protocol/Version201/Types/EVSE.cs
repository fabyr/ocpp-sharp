using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct EVSE
{
    public static readonly EVSE Empty = new();

    [JsonProperty("id")]
    public ulong Id { get; set; }

    [JsonProperty("connectorId")]
    public long ConnectorId { get; set; }
}
