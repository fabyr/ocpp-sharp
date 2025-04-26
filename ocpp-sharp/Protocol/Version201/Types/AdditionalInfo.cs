using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct AdditionalInfo
{
    public static readonly AdditionalInfo Empty = new();

    [JsonPropertyName("additionalIdToken")]
    public CiString AdditionalIdToken { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } // Custom type not defined in protocol
}
