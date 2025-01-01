using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class BootReasonType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(BootReasonType.ApplicationReset)]
        ApplicationReset,

        [StringValue(BootReasonType.FirmwareUpdate)]
        FirmwareUpdate,

        [StringValue(BootReasonType.LocalReset)]
        LocalReset,

        [StringValue(BootReasonType.PowerUp)]
        PowerUp,

        [StringValue(BootReasonType.RemoteReset)]
        RemoteReset,

        [StringValue(BootReasonType.ScheduledReset)]
        ScheduledReset,

        [StringValue(BootReasonType.Triggered)]
        Triggered,

        [StringValue(BootReasonType.Unknown)]
        Unknown,

        [StringValue(BootReasonType.Watchdog)]
        Watchdog
    }

    public const string ApplicationReset = "ApplicationReset";
    public const string FirmwareUpdate = "FirmwareUpdate";
    public const string LocalReset = "LocalReset";
    public const string PowerUp = "PowerUp";
    public const string RemoteReset = "RemoteReset";
    public const string ScheduledReset = "ScheduledReset";
    public const string Triggered = "Triggered";
    public const string Unknown = "Unknown";
    public const string Watchdog = "Watchdog";
}
