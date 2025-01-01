using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class ChargingStateType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ChargingStateType.Charging)]
        Charging,

        [StringValue(ChargingStateType.EVConnected)]
        EVConnected,

        [StringValue(ChargingStateType.SuspendedEV)]
        SuspendedEV,

        [StringValue(ChargingStateType.SuspendedEVSE)]
        SuspendedEVSE,

        [StringValue(ChargingStateType.Idle)]
        Idle
    }

    public const string Charging = "Charging";
    public const string EVConnected = "EVConnected";
    public const string SuspendedEV = "SuspendedEV";
    public const string SuspendedEVSE = "SuspendedEVSE";
    public const string Idle = "Idle";
}
