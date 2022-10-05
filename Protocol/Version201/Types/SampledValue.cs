using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct SampledValue
    {
        public static readonly SampledValue Empty = new SampledValue();

        public double value;
        public ReadingContextType.Enum? context; // Default = Sample.Periodic
    }
}