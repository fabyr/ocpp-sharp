using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class PhaseType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(PhaseType.L1)]
			L1,
            [StringValue(PhaseType.L2)]
			L2,
            [StringValue(PhaseType.L3)]
			L3,
            [StringValue(PhaseType.N)]
			N,
            [StringValue(PhaseType.L1_N)]
			L1_N,
            [StringValue(PhaseType.L2_N)]
			L2_N,
            [StringValue(PhaseType.L3_N)]
			L3_N,
            [StringValue(PhaseType.L1_L2)]
			L1_L2,
            [StringValue(PhaseType.L2_L3)]
			L2_L3,
            [StringValue(PhaseType.L3_L1)]
			L3_L1,
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
}