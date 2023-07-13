using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct MeterValue
    {
        public static readonly MeterValue Empty = new MeterValue();

        public DateTime timestamp;
        public SampledValue[]? sampledValue;
    }
}