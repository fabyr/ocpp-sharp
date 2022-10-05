using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct MessageContent
    {
        public static readonly MessageContent Empty = new MessageContent();

        public MessageFormatType.Enum format;
        public string? language;
        public string content;
    }
}