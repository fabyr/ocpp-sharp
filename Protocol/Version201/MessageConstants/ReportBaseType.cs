using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ReportBaseType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ReportBaseType.ConfigurationInventory)]
            ConfigurationInventory,
            [StringValue(ReportBaseType.FullInventory)]
            FullInventory,
            [StringValue(ReportBaseType.SummaryInventory)]
            SummaryInventory
        }
        public const string ConfigurationInventory = "ConfigurationInventory";
        public const string FullInventory = "FullInventory";
        public const string SummaryInventory = "SummaryInventory";
    }
}