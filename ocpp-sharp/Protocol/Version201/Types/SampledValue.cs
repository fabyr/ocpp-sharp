using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct SampledValue
{
    public static readonly SampledValue Empty = new();

    [JsonPropertyName("value")]
    public double Value { get; set; }

    [JsonPropertyName("context")]
    public ReadingContextType.Enum? Context { get; set; } // Default = Sample.Periodic

    [JsonPropertyName("measurand")]
    public MeasurandType.Enum? Measurand { get; set; }

    [JsonPropertyName("phase")]
    public PhaseType.Enum? Phase { get; set; }

    [JsonPropertyName("location")]
    public LocationType.Enum? Location { get; set; }

    [JsonPropertyName("signedMeterValue")]
    public SignedMeterValue? SignedMeterValue { get; set; }

    [JsonPropertyName("unitOfMeasure")]
    public UnitOfMeasure? UnitOfMeasure { get; set; }
}
