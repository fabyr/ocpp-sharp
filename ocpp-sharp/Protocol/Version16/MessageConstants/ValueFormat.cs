using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class ValueFormat
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ValueFormat.Raw)]
            Raw,
            [StringValue(ValueFormat.SignedData)]
            SignedData
        }
        public const string Raw = "Raw";
        public const string SignedData = "SignedData";
    }
}