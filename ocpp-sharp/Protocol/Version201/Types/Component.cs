using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct Component
{
    public static readonly Component Empty = new();

    [JsonProperty("name")]
    public CiString Name { get; set; }

    [JsonProperty("instance")]
    public CiString? Instance { get; set; }

    [JsonProperty("evse")]
    public EVSE? Evse { get; set; }
}
