using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class MessageTriggerType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(MessageTriggerType.BootNotification)]
			BootNotification,
            [StringValue(MessageTriggerType.LogStatusNotification)]
			LogStatusNotification,
            [StringValue(MessageTriggerType.FirmwareStatusNotification)]
			FirmwareStatusNotification,
            [StringValue(MessageTriggerType.Heartbeat)]
			Heartbeat,
            [StringValue(MessageTriggerType.MeterValues)]
			MeterValues,
            [StringValue(MessageTriggerType.SignChargingStationCertificate)]
			SignChargingStationCertificate,
            [StringValue(MessageTriggerType.SignV2GCertificate)]
			SignV2GCertificate,
            [StringValue(MessageTriggerType.StatusNotification)]
			StatusNotification,
            [StringValue(MessageTriggerType.TransactionEvent)]
			TransactionEvent,
            [StringValue(MessageTriggerType.SignCombinedCertificate)]
			SignCombinedCertificate,
            [StringValue(MessageTriggerType.PublishFirmwareStatusNotification)]
			PublishFirmwareStatusNotification
        }
        public const string BootNotification = "BootNotification";
        public const string LogStatusNotification = "LogStatusNotification";
        public const string FirmwareStatusNotification = "FirmwareStatusNotification";
        public const string Heartbeat = "Heartbeat";
        public const string MeterValues = "MeterValues";
        public const string SignChargingStationCertificate = "SignChargingStationCertificate";
        public const string SignV2GCertificate = "SignV2GCertificate";
        public const string StatusNotification = "StatusNotification";
        public const string TransactionEvent = "TransactionEvent";
        public const string SignCombinedCertificate = "SignCombinedCertificate";
        public const string PublishFirmwareStatusNotification = "PublishFirmwareStatusNotification";
    }
}