using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class UnpublishFirmwareStatusType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(UnpublishFirmwareStatusType.DownloadOngoing)]
            DownloadOngoing,
            [StringValue(UnpublishFirmwareStatusType.NoFirmware)]
            NoFirmware,
            [StringValue(UnpublishFirmwareStatusType.Unpublished)]
            Unpublished
        }
        public const string DownloadOngoing = "DownloadOngoing";
        public const string NoFirmware = "NoFirmware";
        public const string Unpublished = "Unpublished";
    }
}