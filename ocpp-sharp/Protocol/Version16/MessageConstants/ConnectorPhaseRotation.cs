using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ConnectorPhaseRotation
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ConnectorPhaseRotation.NotApplicable)]
        NotApplicable,

        [StringValue(ConnectorPhaseRotation.Unknown)]
        Unknown,

        [StringValue(ConnectorPhaseRotation.RST)]
        RST,

        [StringValue(ConnectorPhaseRotation.RTS)]
        RTS,

        [StringValue(ConnectorPhaseRotation.SRT)]
        SRT,

        [StringValue(ConnectorPhaseRotation.STR)]
        STR,

        [StringValue(ConnectorPhaseRotation.TRS)]
        TRS,

        [StringValue(ConnectorPhaseRotation.TSR)]
        TSR
    }

    public const string NotApplicable = "NotApplicable";
    public const string Unknown = "Unknown";
    public const string RST = "RST";
    public const string RTS = "RTS";
    public const string SRT = "SRT";
    public const string STR = "STR";
    public const string TRS = "TRS";
    public const string TSR = "TSR";
}
