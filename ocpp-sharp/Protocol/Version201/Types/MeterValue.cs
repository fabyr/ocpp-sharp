using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct MeterValue
    {
        public static readonly MeterValue Empty = new MeterValue();

        public DateTime timestamp;

        /// <summary>
        /// Must contain atleast one entry.
        /// </summary>
        public SampledValue[] sampledValue;
    }
}