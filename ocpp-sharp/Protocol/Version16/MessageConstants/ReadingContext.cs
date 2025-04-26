using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class ReadingContext
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(ReadingContext.InterruptionBegin)]
        InterruptionBegin,

        [StringValue(ReadingContext.InterruptionEnd)]
        InterruptionEnd,

        [StringValue(ReadingContext.Other)]
        Other,

        [StringValue(ReadingContext.SampleClock)]
        SampleClock,

        [StringValue(ReadingContext.SamplePeriodic)]
        SamplePeriodic,

        [StringValue(ReadingContext.TransactionBegin)]
        TransactionBegin,

        [StringValue(ReadingContext.TransactionEnd)]
        TransactionEnd,

        [StringValue(ReadingContext.Trigger)]
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
