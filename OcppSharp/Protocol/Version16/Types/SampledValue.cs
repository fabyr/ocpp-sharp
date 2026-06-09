using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct SampledValue
{
    public static readonly SampledValue Empty = new();

    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <summary>
    /// Valid values in <see cref="ReadingContext"/>
    /// </summary>
    [JsonPropertyName("context")]
    public ReadingContext.Enum? Context { get; set; }

    /// <summary>
    /// Valid values in <see cref="ValueFormat"/>
    /// </summary>
    [JsonPropertyName("format")]
    public ValueFormat.Enum? Format { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Measurand"/>
    /// </summary>
    [JsonPropertyName("measurand")]
    public Measurand.Enum? Measurand { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Phase"/>
    /// </summary>
    [JsonPropertyName("phase")]
    public Phase.Enum? Phase { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.Location"/>
    /// </summary>
    [JsonPropertyName("location")]
    public Location.Enum? Location { get; set; }

    /// <summary>
    /// Valid values in <see cref="UnitOfMeasure"/> <br/>
    /// Default according to specification: <see cref="UnitOfMeasure.Enum.Wh"/>
    /// </summary>
    [JsonPropertyName("unit")]
    public UnitOfMeasure.Enum? Unit { get; set; }
}
