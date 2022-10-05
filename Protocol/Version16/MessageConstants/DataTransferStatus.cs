using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class DataTransferStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(DataTransferStatus.Accepted)]
            Accepted,
            [StringValue(DataTransferStatus.Rejected)]
            Rejected,
            [StringValue(DataTransferStatus.UnknownMessageId)]
            UnknownMessageId,
            [StringValue(DataTransferStatus.UnknownVendorId)]
            UnknownVendorId
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
        public const string UnknownMessageId = "UnknownMessageId";
        public const string UnknownVendorId = "UnknownVendorId";
    }
}