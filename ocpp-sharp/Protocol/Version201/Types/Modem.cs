using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct Modem
{
    public static readonly Modem Empty = new();

    [JsonProperty("iccid")]
    public CiString Iccid { get; set; }

    [JsonProperty("imsi")]
    public CiString Imsi { get; set; }
}
