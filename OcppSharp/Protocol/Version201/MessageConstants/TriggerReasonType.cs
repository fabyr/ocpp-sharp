using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class TriggerReasonType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(TriggerReasonType.Authorized)]
        Authorized,

        [StringValue(TriggerReasonType.CablePluggedIn)]
        CablePluggedIn,

        [StringValue(TriggerReasonType.ChargingRateChanged)]
        ChargingRateChanged,

        [StringValue(TriggerReasonType.ChargingStateChanged)]
        ChargingStateChanged,

        [StringValue(TriggerReasonType.Deauthorized)]
        Deauthorized,

        [StringValue(TriggerReasonType.EnergyLimitReached)]
        EnergyLimitReached,

        [StringValue(TriggerReasonType.EVCommunicationLost)]
        EVCommunicationLost,

        [StringValue(TriggerReasonType.EVConnectTimeout)]
        EVConnectTimeout,

        [StringValue(TriggerReasonType.MeterValueClock)]
        MeterValueClock,

        [StringValue(TriggerReasonType.MeterValuePeriodic)]
        MeterValuePeriodic,

        [StringValue(TriggerReasonType.TimeLimitReached)]
        TimeLimitReached,

        [StringValue(TriggerReasonType.Trigger)]
        Trigger,

        [StringValue(TriggerReasonType.UnlockCommand)]
        UnlockCommand,

        [StringValue(TriggerReasonType.StopAuthorized)]
        StopAuthorized,

        [StringValue(TriggerReasonType.EVDeparted)]
        EVDeparted,

        [StringValue(TriggerReasonType.EVDetected)]
        EVDetected,

        [StringValue(TriggerReasonType.RemoteStop)]
        RemoteStop,

        [StringValue(TriggerReasonType.RemoteStart)]
        RemoteStart,

        [StringValue(TriggerReasonType.AbnormalCondition)]
        AbnormalCondition,

        [StringValue(TriggerReasonType.SignedDataReceived)]
        SignedDataReceived,

        [StringValue(TriggerReasonType.ResetCommand)]
        ResetCommand
    }

    public const string Authorized = "Authorized";
    public const string CablePluggedIn = "CablePluggedIn";
    public const string ChargingRateChanged = "ChargingRateChanged";
    public const string ChargingStateChanged = "ChargingStateChanged";
    public const string Deauthorized = "Deauthorized";
    public const string EnergyLimitReached = "EnergyLimitReached";
    public const string EVCommunicationLost = "EVCommunicationLost";
    public const string EVConnectTimeout = "EVConnectTimeout";
    public const string MeterValueClock = "MeterValueClock";
    public const string MeterValuePeriodic = "MeterValuePeriodic";
    public const string TimeLimitReached = "TimeLimitReached";
    public const string Trigger = "Trigger";
    public const string UnlockCommand = "UnlockCommand";
    public const string StopAuthorized = "StopAuthorized";
    public const string EVDeparted = "EVDeparted";
    public const string EVDetected = "EVDetected";
    public const string RemoteStop = "RemoteStop";
    public const string RemoteStart = "RemoteStart";
    public const string AbnormalCondition = "AbnormalCondition";
    public const string SignedDataReceived = "SignedDataReceived";
    public const string ResetCommand = "ResetCommand";
}
