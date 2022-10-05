using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct DCChargingParameters
    {
        public static readonly DCChargingParameters Empty = new DCChargingParameters();
        
        public int evMaxCurrent;
        public int evMaxVoltage;
        public int energyAmount;
        public int evMaxPower;

        /// <summary>
        /// Value range: [0; 100]
        /// (0 to 100, both inclusive)
        /// </summary>
        public int stateOfCharge;
    }
}