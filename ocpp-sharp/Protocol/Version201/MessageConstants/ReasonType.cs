using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ReasonType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ReasonType.DeAuthorized)]
        DeAuthorized,

        [StringValue(ReasonType.EmergencyStop)]
        EmergencyStop,

        [StringValue(ReasonType.EnergyLimitReached)]
        EnergyLimitReached,

        [StringValue(ReasonType.EVDisconnected)]
        EVDisconnected,

        [StringValue(ReasonType.GroundFault)]
        GroundFault,

        [StringValue(ReasonType.ImmediateReset)]
        ImmediateReset,

        [StringValue(ReasonType.Local)]
        Local,

        [StringValue(ReasonType.LocalOutOfCredit)]
        LocalOutOfCredit,

        [StringValue(ReasonType.MasterPass)]
        MasterPass,

        [StringValue(ReasonType.Other)]
        Other,

        [StringValue(ReasonType.OvercurrentFault)]
        OvercurrentFault,

        [StringValue(ReasonType.PowerLoss)]
        PowerLoss,

        [StringValue(ReasonType.PowerQuality)]
        PowerQuality,

        [StringValue(ReasonType.Reboot)]
        Reboot,

        [StringValue(ReasonType.Remote)]
        Remote,

        [StringValue(ReasonType.SOCLimitReached)]
        SOCLimitReached,

        [StringValue(ReasonType.StoppedByEV)]
        StoppedByEV,

        [StringValue(ReasonType.TimeLimitReached)]
        TimeLimitReached,

        [StringValue(ReasonType.Timeout)]
        Timeout
    }

    public const string DeAuthorized = "DeAuthorized";
    public const string EmergencyStop = "EmergencyStop";
    public const string EnergyLimitReached = "EnergyLimitReached";
    public const string EVDisconnected = "EVDisconnected";
    public const string GroundFault = "GroundFault";
    public const string ImmediateReset = "ImmediateReset";
    public const string Local = "Local";
    public const string LocalOutOfCredit = "LocalOutOfCredit";
    public const string MasterPass = "MasterPass";
    public const string Other = "Other";
    public const string OvercurrentFault = "OvercurrentFault";
    public const string PowerLoss = "PowerLoss";
    public const string PowerQuality = "PowerQuality";
    public const string Reboot = "Reboot";
    public const string Remote = "Remote";
    public const string SOCLimitReached = "SOCLimitReached";
    public const string StoppedByEV = "StoppedByEV";
    public const string TimeLimitReached = "TimeLimitReached";
    public const string Timeout = "Timeout";
}
