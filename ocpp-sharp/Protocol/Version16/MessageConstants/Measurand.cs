using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class Measurand
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(Measurand.CurrentExport)]
        CurrentExport,

        [StringValue(Measurand.CurrentImport)]
        CurrentImport,

        [StringValue(Measurand.CurrentOffered)]
        CurrentOffered,

        [StringValue(Measurand.EnergyActiveExportRegister)]
        EnergyActiveExportRegister,

        [StringValue(Measurand.EnergyActiveImportRegister)]
        EnergyActiveImportRegister,

        [StringValue(Measurand.EnergyReactiveExportRegister)]
        EnergyReactiveExportRegister,

        [StringValue(Measurand.EnergyReactiveImportRegister)]
        EnergyReactiveImportRegister,

        [StringValue(Measurand.EnergyActiveExportInterval)]
        EnergyActiveExportInterval,

        [StringValue(Measurand.EnergyActiveImportInterval)]
        EnergyActiveImportInterval,

        [StringValue(Measurand.EnergyReactiveExportInterval)]
        EnergyReactiveExportInterval,

        [StringValue(Measurand.EnergyReactiveImportInterval)]
        EnergyReactiveImportInterval,

        [StringValue(Measurand.Frequency)]
        Frequency,

        [StringValue(Measurand.PowerActiveExport)]
        PowerActiveExport,

        [StringValue(Measurand.PowerActiveImport)]
        PowerActiveImport,

        [StringValue(Measurand.PowerFactor)]
        PowerFactor,

        [StringValue(Measurand.PowerOffered)]
        PowerOffered,

        [StringValue(Measurand.PowerReactiveExport)]
        PowerReactiveExport,

        [StringValue(Measurand.PowerReactiveImport)]
        PowerReactiveImport,

        [StringValue(Measurand.RPM)]
        RPM,

        [StringValue(Measurand.SoC)]
        SoC,

        [StringValue(Measurand.Temperature)]
        Temperature,

        [StringValue(Measurand.Voltage)]
        Voltage
    }

    public const string CurrentExport = "Current.Export";
    public const string CurrentImport = "Current.Import";
    public const string CurrentOffered = "Current.Offered";
    public const string EnergyActiveExportRegister = "Energy.Active.Export.Register";
    public const string EnergyActiveImportRegister = "Energy.Active.Import.Register";
    public const string EnergyReactiveExportRegister = "Energy.Reactive.Export.Register";
    public const string EnergyReactiveImportRegister = "Energy.Reactive.Import.Register";
    public const string EnergyActiveExportInterval = "Energy.Active.Export.Interval";
    public const string EnergyActiveImportInterval = "Energy.Active.Import.Interval";
    public const string EnergyReactiveExportInterval = "Energy.Reactive.Export.Interval";
    public const string EnergyReactiveImportInterval = "Energy.Reactive.Import.Interval";
    public const string Frequency = "Frequency";
    public const string PowerActiveExport = "Power.Active.Export";
    public const string PowerActiveImport = "Power.Active.Import";
    public const string PowerFactor = "Power.Factor";
    public const string PowerOffered = "Power.Offered";
    public const string PowerReactiveExport = "Power.Reactive.Export";
    public const string PowerReactiveImport = "Power.Reactive.Import";
    public const string RPM = "RPM";
    public const string SoC = "SoC";
    public const string Temperature = "Temperature";
    public const string Voltage = "Voltage";
}
