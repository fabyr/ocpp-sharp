using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ComponentCriterionType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ComponentCriterionType.Active)]
            Active,
            [StringValue(ComponentCriterionType.Available)]
            Available,
            [StringValue(ComponentCriterionType.Enabled)]
            Enabled,
            [StringValue(ComponentCriterionType.Problem)]
            Problem
        }
        public const string Active = "Active";
        public const string Available = "Available";
        public const string Enabled = "Enabled";
        public const string Problem = "Problem";
    }
}