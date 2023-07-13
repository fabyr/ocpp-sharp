using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class ReadingContextType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(ReadingContextType.InterruptionBegin)]
            InterruptionBegin,
            [StringValue(ReadingContextType.InterruptionEnd)]
            InterruptionEnd,
            [StringValue(ReadingContextType.Other)]
            Other,
            [StringValue(ReadingContextType.SampleClock)]
            SampleClock,
            [StringValue(ReadingContextType.SamplePeriodic)]
            SamplePeriodic,
            [StringValue(ReadingContextType.TransactionBegin)]
            TransactionBegin,
            [StringValue(ReadingContextType.TransactionEnd)]
            TransactionEnd,
            [StringValue(ReadingContextType.Trigger)]
            Trigger
        }
        public const string InterruptionBegin = "Interruption.Begin";
        public const string InterruptionEnd = "Interruption.End";
        public const string Other = "Other";
        public const string SampleClock = "Sample.Clock";
        public const string SamplePeriodic = "Sample.Periodic";
        public const string TransactionBegin = "Transaction.Begin";
        public const string TransactionEnd = "Transaction.End";
        public const string Trigger = "Trigger";
    }
}