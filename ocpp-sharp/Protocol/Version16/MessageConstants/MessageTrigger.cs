using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class MessageTrigger
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(MessageTrigger.BootNotification)]
        BootNotification,

        [StringValue(MessageTrigger.DiagnosticsStatusNotification)]
        DiagnosticsStatusNotification,

        [StringValue(MessageTrigger.FirmwareStatusNotification)]
        FirmwareStatusNotification,

        [StringValue(MessageTrigger.Heartbeat)]
        Heartbeat,

        [StringValue(MessageTrigger.MeterValues)]
        MeterValues,

        [StringValue(MessageTrigger.StatusNotification)]
        StatusNotification
    }

    public const string BootNotification = "BootNotification";
    public const string DiagnosticsStatusNotification = "DiagnosticsStatusNotification";
    public const string FirmwareStatusNotification = "FirmwareStatusNotification";
    public const string Heartbeat = "Heartbeat";
    public const string MeterValues = "MeterValues";
    public const string StatusNotification = "StatusNotification";
}
