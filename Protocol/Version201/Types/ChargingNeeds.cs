using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ChargingNeeds
    {
        public static readonly ChargingNeeds Empty = new ChargingNeeds();

        public EnergyTransferModeType.Enum requestedEnergyTransfer;
        public DateTime? departureTime;
        public ACChargingParameters? acChargingParameters;
        public DCChargingParameters? dcChargingParameters;
    }
}