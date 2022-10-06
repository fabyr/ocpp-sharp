using System;

namespace OcppSharp.Protocol.Version201.MessageConstants
{
    public static class MeasurandType
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(MeasurandType.CurrentExport)]
			CurrentExport,
            [StringValue(MeasurandType.CurrentImport)]
			CurrentImport,
            [StringValue(MeasurandType.CurrentOffered)]
			CurrentOffered,
            [StringValue(MeasurandType.EnergyActiveExportRegister)]
			EnergyActiveExportRegister,
            [StringValue(MeasurandType.EnergyActiveImportRegister)]
			EnergyActiveImportRegister,
            [StringValue(MeasurandType.EnergyReactiveExportRegister)]
			EnergyReactiveExportRegister,
            [StringValue(MeasurandType.EnergyReactiveImportRegister)]
			EnergyReactiveImportRegister,
            [StringValue(MeasurandType.EnergyActiveExportInterval)]
			EnergyActiveExportInterval,
            [StringValue(MeasurandType.EnergyActiveImportInterval)]
			EnergyActiveImportInterval,
            [StringValue(MeasurandType.EnergyActiveNet)]
			EnergyActiveNet,
            [StringValue(MeasurandType.EnergyReactiveExportInterval)]
			EnergyReactiveExportInterval,
            [StringValue(MeasurandType.EnergyReactiveImportInterval)]
			EnergyReactiveImportInterval,
            [StringValue(MeasurandType.EnergyReactiveNet)]
			EnergyReactiveNet,
            [StringValue(MeasurandType.EnergyApparentNet)]
			EnergyApparentNet,
            [StringValue(MeasurandType.EnergyApparentImport)]
			EnergyApparentImport,
            [StringValue(MeasurandType.EnergyApparentExport)]
			EnergyApparentExport,
            [StringValue(MeasurandType.Frequency)]
			Frequency,
            [StringValue(MeasurandType.PowerActiveExport)]
			PowerActiveExport,
            [StringValue(MeasurandType.PowerActiveImport)]
			PowerActiveImport,
            [StringValue(MeasurandType.PowerFactor)]
			PowerFactor,
            [StringValue(MeasurandType.PowerOffered)]
			PowerOffered,
            [StringValue(MeasurandType.PowerReactiveExport)]
			PowerReactiveExport,
            [StringValue(MeasurandType.PowerReactiveImport)]
			PowerReactiveImport,
            [StringValue(MeasurandType.SoC)]
			SoC,
            [StringValue(MeasurandType.Voltage)]
			Voltage
        }

        public const string CurrentExport = "Current.Export";
        public const string CurrentImport = "Current.Import";
        public const string CurrentOffered = "CurrentOffered";
        public const string EnergyActiveExportRegister = "Energy.Active.Export.Register";
        public const string EnergyActiveImportRegister = "Energy.Active.Import.Register";
        public const string EnergyReactiveExportRegister = "Energy.Reactive.Export.Register";
        public const string EnergyReactiveImportRegister = "Energy.Reactive.Import.Register";
        public const string EnergyActiveExportInterval = "Energy.Active.Export.Interval";
        public const string EnergyActiveImportInterval = "Energy.Active.Import.Interval";
        public const string EnergyActiveNet = "Energy.Active.Net";
        public const string EnergyReactiveExportInterval = "Energy.Reactive.Export.Interval";
        public const string EnergyReactiveImportInterval = "Energy.Reactive.Import.Interval";
        public const string EnergyReactiveNet = "Energy.Reactive.Net";
        public const string EnergyApparentNet = "Energy.Apparent.Net";
        public const string EnergyApparentImport = "Energy.Apparent.Import";
        public const string EnergyApparentExport = "Energy.Apparent.Export";
        public const string Frequency = "Frequency";
        public const string PowerActiveExport = "Power.Active.Export";
        public const string PowerActiveImport = "Power.Active.Import";
        public const string PowerFactor = "Power.Factor";
        public const string PowerOffered = "Power.Offered";
        public const string PowerReactiveExport = "Power.Reactive.Export";
        public const string PowerReactiveImport = "Power.Reactive.Import";
        public const string SoC = "SoC";
        public const string Voltage = "Voltage";
    }
}