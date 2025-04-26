using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class VPNType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(VPNType.IKEv2)]
        IKEv2,

        [StringValue(VPNType.IPSec)]
        IPSec,

        [StringValue(VPNType.L2TP)]
        L2TP,

        [StringValue(VPNType.PPTP)]
        PPTP
    }

    public const string IKEv2 = "IKEv2";
    public const string IPSec = "IPSec";
    public const string L2TP = "L2TP";
    public const string PPTP = "PPTP";
}
