using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct Firmware
    {
        public static readonly Firmware Empty = new Firmware();

        public string location;
        public DateTime retrieveDateTime;
        public DateTime? installDateTime;
        public string? signingCertificate;
        public string? signature;
    }
}