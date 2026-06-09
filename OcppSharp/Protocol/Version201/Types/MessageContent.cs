using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct MessageContent
{
    public static readonly MessageContent Empty = new();

    [JsonPropertyName("format")]
    public MessageFormatType.Enum Format { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }
}
