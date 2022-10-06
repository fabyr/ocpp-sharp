using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class MonitoringBaseType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(MonitoringBaseType.All)]
            All,
            [StringValue(MonitoringBaseType.FactoryDefault)]
            FactoryDefault,
            [StringValue(MonitoringBaseType.HardWiredOnly)]
            HardWiredOnly
        }
        public const string All = "All";
        public const string FactoryDefault = "FactoryDefault";
        public const string HardWiredOnly = "HardWiredOnly";
    }
}