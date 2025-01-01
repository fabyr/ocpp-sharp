using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class Reason
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(Reason.EmergencyStop)]
        EmergencyStop,

        [StringValue(Reason.EVDisconnected)]
        EVDisconnected,

        [StringValue(Reason.HardReset)]
        HardReset,

        [StringValue(Reason.Local)]
        Local,

        [StringValue(Reason.Other)]
        Other,

        [StringValue(Reason.PowerLoss)]
        PowerLoss,

        [StringValue(Reason.Reboot)]
        Reboot,

        [StringValue(Reason.Remote)]
        Remote,

        [StringValue(Reason.SoftReset)]
        SoftReset,

        [StringValue(Reason.UnlockCommand)]
        UnlockCommand,

        [StringValue(Reason.DeAuthorized)]
        DeAuthorized
    }

    public const string EmergencyStop = "EmergencyStop";
    public const string EVDisconnected = "EVDisconnected";
    public const string HardReset = "HardReset";
    public const string Local = "Local";
    public const string Other = "Other";
    public const string PowerLoss = "PowerLoss";
    public const string Reboot = "Reboot";
    public const string Remote = "Remote";
    public const string SoftReset = "SoftReset";
    public const string UnlockCommand = "UnlockCommand";
    public const string DeAuthorized = "DeAuthorized";
}
