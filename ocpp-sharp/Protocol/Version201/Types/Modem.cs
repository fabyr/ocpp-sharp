using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct Modem
{
    public static readonly Modem Empty = new();

    [JsonPropertyName("iccid")]
    public CiString Iccid { get; set; }

    [JsonPropertyName("imsi")]
    public CiString Imsi { get; set; }
}
