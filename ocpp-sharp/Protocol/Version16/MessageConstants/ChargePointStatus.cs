using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ChargePointStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ChargePointStatus.Available)]
        Available,

        [StringValue(ChargePointStatus.Preparing)]
        Preparing,

        [StringValue(ChargePointStatus.Charging)]
        Charging,

        [StringValue(ChargePointStatus.SuspendedEVSE)]
        SuspendedEVSE,

        [StringValue(ChargePointStatus.SuspendedEV)]
        SuspendedEV,

        [StringValue(ChargePointStatus.Finishing)]
        Finishing,

        [StringValue(ChargePointStatus.Reserved)]
        Reserved,

        [StringValue(ChargePointStatus.Unavailable)]
        Unavailable,

        [StringValue(ChargePointStatus.Faulted)]
        Faulted
    }

    public const string Available = "Available";
    public const string Preparing = "Preparing";
    public const string Charging = "Charging";
    public const string SuspendedEVSE = "SuspendedEVSE";
    public const string SuspendedEV = "SuspendedEV";
    public const string Finishing = "Finishing";
    public const string Reserved = "Reserved";
    public const string Unavailable = "Unavailable";
    public const string Faulted = "Faulted";
}
