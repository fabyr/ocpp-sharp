using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class MessageFormatType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(MessageFormatType.ASCII)]
        ASCII,

        [StringValue(MessageFormatType.HTML)]
        HTML,

        [StringValue(MessageFormatType.URI)]
        URI,

        [StringValue(MessageFormatType.UTF8)]
        UTF8
    }

    public const string ASCII = "ASCII";
    public const string HTML = "HTML";
    public const string URI = "URI";
    public const string UTF8 = "UTF8";
}
