namespace OcppSharp.Protocol.Version201.Standard;

public enum UnitOfMeasure
{
    [StringValue("A")]
    Ampere,

    [StringValue("ASU")]
    ArbitraryStrengthUnit,

    [StringValue("B")]
    Bytes,

    [StringValue("Celsius")]
    Celsius,

    [StringValue("dB")]
    Decibel,

    [StringValue("dBm")]
    DecibelMilliWatts,

    [StringValue("Deg")]
    Degrees,

    [StringValue("Fahrenheit")]
    Fahrenheit,

    [StringValue("Hz")]
    Hertz,

    [StringValue("K")]
    Kelvin,

    [StringValue("lx")]
    Lux,

    [StringValue("m")]
    Meter,

    [StringValue("ms2")]
    MetersPerSecondSquared,

    [StringValue("N")]
    Netwon,

    [StringValue("Ohm")]
    Ohm,

    [StringValue("kPa")]
    KiloPascal,

    [StringValue("Percent")]
    Percent,

    [StringValue("RH")]
    RelativeHumidityPercent,

    [StringValue("RPM")]
    RevolutionsPerMinute,

    [StringValue("s")]
    Seconds,

    [StringValue("V")]
    Volt,

    [StringValue("VA")]
    VoltAmpere,

    [StringValue("kVA")]
    KiloVoltAmpere,

    [StringValue("VAh")]
    VoltAmpereHours,

    [StringValue("kVAh")]
    KiloVoltAmpereHours,

    [StringValue("var")]
    VoltAmpereReactive,

    [StringValue("kvar")]
    KiloVoltAmpereReactive,

    [StringValue("varh")]
    VoltAmpereReactiveHours,

    [StringValue("kvarh")]
    KiloVoltAmpereReactiveHours,

    [StringValue("W")]
    Watt,

    [StringValue("kW")]
    KiloWatt,

    [StringValue("Wh")]
    WattHours,

    [StringValue("kWh")]
    KiloWattHours
}
