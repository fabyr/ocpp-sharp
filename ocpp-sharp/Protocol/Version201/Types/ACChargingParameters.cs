using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ACChargingParameters
    {
        public static readonly ACChargingParameters Empty = new ACChargingParameters();

        public int energyAmount;
        public int evMinCurrent;
        public int evMaxCurrent;
        public int evMaxVoltage;
    }
}