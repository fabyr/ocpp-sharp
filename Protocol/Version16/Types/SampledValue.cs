using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct SampledValue
    {
        public static readonly SampledValue Empty = new SampledValue();

        public string value;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ReadingContext"/>
        /// </summary>
        public MessageConstants.ReadingContext.Enum? context;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.ValueFormat"/>
        /// </summary>
        public MessageConstants.ValueFormat.Enum? format;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.Measurand"/>
        /// </summary>
        public MessageConstants.Measurand.Enum? measurand;// = MessageConstants.Measurand.Enum.EnergyActiveImportRegister;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.Phase"/>
        /// </summary>
        public MessageConstants.Phase.Enum? phase;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.Location"/>
        /// </summary>
        public MessageConstants.Location.Enum? location;

        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.UnitOfMeasure"/>
        /// </summary>
        public MessageConstants.UnitOfMeasure.Enum? unit; // Default = MessageConstants.UnitOfMeasure.Enum.Wh;
    }
}