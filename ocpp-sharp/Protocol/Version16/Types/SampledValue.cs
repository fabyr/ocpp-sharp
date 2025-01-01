using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct SampledValue
{
    public static readonly SampledValue Empty = new();

    [JsonProperty("value")]
    public string Value { get; set; }

    /// <summary>
    /// Valid values in <see cref="ReadingContext"/>
    /// </summary>
    [JsonProperty("context")]
    public ReadingContext.Enum? Context { get; set; }

    /// <summary>
    /// Valid values in <see cref="ValueFormat"/>
    /// </summary>
    [JsonProperty("format")]
    public ValueFormat.Enum? Format { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Measurand"/>
    /// </summary>
    [JsonProperty("measurand")]
    public Measurand.Enum? Measurand { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Phase"/>
    /// </summary>
    [JsonProperty("phase")]
    public Phase.Enum? Phase { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Location"/>
    /// </summary>
    [JsonProperty("location")]
    public Location.Enum? Location { get; set; }

    /// <summary>
    /// Valid values in <see cref="UnitOfMeasure"/> <br/>
    /// Default according to specification: <see cref="UnitOfMeasure.Enum.Wh"/>
    /// </summary>
    [JsonProperty("unit")]
    public UnitOfMeasure.Enum? Unit { get; set; }
}
