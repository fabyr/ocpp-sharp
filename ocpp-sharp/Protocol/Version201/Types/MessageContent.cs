using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct MessageContent
{
    public static readonly MessageContent Empty = new();

    [JsonProperty("format")]
    public MessageFormatType.Enum Format { get; set; }

    [JsonProperty("language")]
    public string? Language { get; set; }

    [JsonProperty("content")]
    public string Content { get; set; }
}
