using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct ChargingStation
    {
        public static readonly ChargingStation Empty = new ChargingStation();

        public string? serialNumber;
        public string model;
        public string vendorName;
        public string? firmwareVersion;
        public Modem? modem;
    }
}