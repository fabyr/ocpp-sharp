using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class DataTransferStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(DataTransferStatusType.Accepted)]
            Accepted,
            [StringValue(DataTransferStatusType.Rejected)]
            Rejected,
            [StringValue(DataTransferStatusType.UnknownMessageId)]
            UnknownMessageId,
            [StringValue(DataTransferStatusType.UnknownVendorId)]
            UnknownVendorId
        }
        public const string Accepted = "Accepted";
        public const string Rejected = "Rejected";
        public const string UnknownMessageId = "UnknownMessageId";
        public const string UnknownVendorId = "UnknownVendorId";
    }
}