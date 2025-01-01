using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct SampledValue
{
    public static readonly SampledValue Empty = new();

    [JsonProperty("value")]
    public double Value { get; set; }

    [JsonProperty("context")]
    public ReadingContextType.Enum? Context { get; set; } // Default = Sample.Periodic

    [JsonProperty("measurand")]
    public MeasurandType.Enum? Measurand { get; set; }

    [JsonProperty("phase")]
    public PhaseType.Enum? Phase { get; set; }

    [JsonProperty("location")]
    public LocationType.Enum? Location { get; set; }

    [JsonProperty("signedMeterValue")]
    public SignedMeterValue? SignedMeterValue { get; set; }

    [JsonProperty("unitOfMeasure")]
    public UnitOfMeasure? UnitOfMeasure { get; set; }
}
