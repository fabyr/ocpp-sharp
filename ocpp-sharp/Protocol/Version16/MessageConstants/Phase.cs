using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class Phase
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(Phase.L1)]
        L1,

        [StringValue(Phase.L2)]
        L2,

        [StringValue(Phase.L3)]
        L3,

        [StringValue(Phase.N)]
        N,

        [StringValue(Phase.L1_N)]
        L1_N,

        [StringValue(Phase.L2_N)]
        L2_N,

        [StringValue(Phase.L3_N)]
        L3_N,

        [StringValue(Phase.L1_L2)]
        L1_L2,

        [StringValue(Phase.L2_L3)]
        L2_L3,

        [StringValue(Phase.L3_L1)]
        L3_L1
    }

    public const string L1 = "L1";
    public const string L2 = "L2";
    public const string L3 = "L3";
    public const string N = "N";
    public const string L1_N = "L1-N";
    public const string L2_N = "L2-N";
    public const string L3_N = "L3-N";
    public const string L1_L2 = "L1-L2";
    public const string L2_L3 = "L2-L3";
    public const string L3_L1 = "L3-L1";
}
