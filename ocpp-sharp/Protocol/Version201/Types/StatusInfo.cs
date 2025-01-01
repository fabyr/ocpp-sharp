using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct StatusInfo
{
    public static readonly StatusInfo Empty = new();

    [JsonProperty("reasonCode")]
    public CiString ReasonCode { get; set; }

    [JsonProperty("additionalInfo")]
    public string? AdditionalInfo { get; set; }
}
