using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct SignedMeterValue
    {
        public static readonly SignedMeterValue Empty = new SignedMeterValue();

        public string signedMeterData;
        public string signingMethod;
        public string encodingMethod;
        public string publicKey;
    }
}