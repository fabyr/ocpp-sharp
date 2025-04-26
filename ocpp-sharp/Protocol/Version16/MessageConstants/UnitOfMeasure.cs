using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class UnitOfMeasure
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(UnitOfMeasure.Wh)]
        Wh,

        [StringValue(UnitOfMeasure.kWh)]
        kWh,

        [StringValue(UnitOfMeasure.varh)]
        varh,

        [StringValue(UnitOfMeasure.kvarh)]
        kvarh,

        [StringValue(UnitOfMeasure.W)]
        W,

        [StringValue(UnitOfMeasure.kW)]
        kW,

        [StringValue(UnitOfMeasure.VA)]
        VA,

        [StringValue(UnitOfMeasure.var)]
        var,

        [StringValue(UnitOfMeasure.kvar)]
        kvar,

        [StringValue(UnitOfMeasure.A)]
        A,

        [StringValue(UnitOfMeasure.V)]
        V,

        [StringValue(UnitOfMeasure.Celsius)]
        Celsius,

        [StringValue(UnitOfMeasure.Fahrenheit)]
        Fahrenheit,

        [StringValue(UnitOfMeasure.K)]
        K,

        [StringValue(UnitOfMeasure.Percent)]
        Percent
    }

    public const string Wh = "Wh";
    public const string kWh = "kWh";
    public const string varh = "varh";
    public const string kvarh = "kvarh";
    public const string W = "W";
    public const string kW = "kW";
    public const string VA = "VA";
    public const string var = "var";
    public const string kvar = "kvar";
    public const string A = "A";
    public const string V = "V";
    public const string Celsius = "Celsius";
    public const string Fahrenheit = "Fahrenheit";
    public const string K = "K";
    public const string Percent = "Percent";
}
