using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ConnectorType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ConnectorType.cCCS1)]
			cCCS1,
            [StringValue(ConnectorType.cCCS2)]
			cCCS2,
            [StringValue(ConnectorType.cG105)]
			cG105,
            [StringValue(ConnectorType.cTesla)]
			cTesla,
            [StringValue(ConnectorType.cType1)]
			cType1,
            [StringValue(ConnectorType.cType2)]
			cType2,
            [StringValue(ConnectorType.s309_1P_16A)]
			s309_1P_16A
        }
        public const string cCCS1 = "cCCS1";
        public const string cCCS2 = "cCCS2";
        public const string cG105 = "cG105";
        public const string cTesla = "cTesla";
        public const string cType1 = "cType1";
        public const string cType2 = "cType2";
        public const string s309_1P_16A = "s309-1P-16A";
    }
}