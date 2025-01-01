using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct AdditionalInfo
{
    public static readonly AdditionalInfo Empty = new();

    [JsonProperty("additionalIdToken")]
    public CiString AdditionalIdToken { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; } // Custom type not defined in protocol
}
