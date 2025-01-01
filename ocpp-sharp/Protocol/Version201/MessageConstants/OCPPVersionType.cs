using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class OCPPVersionType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(OCPPVersionType.OCPP12)]
        OCPP12,

        [StringValue(OCPPVersionType.OCPP15)]
        OCPP15,

        [StringValue(OCPPVersionType.OCPP16)]
        OCPP16,

        [StringValue(OCPPVersionType.OCPP20)]
        OCPP20
    }

    public const string OCPP12 = "OCPP12";
    public const string OCPP15 = "OCPP15";
    public const string OCPP16 = "OCPP16";
    public const string OCPP20 = "OCPP20";
}
