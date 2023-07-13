using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct OCSPRequestData
    {
        public static readonly OCSPRequestData Empty = new OCSPRequestData();

        public HashAlgorithmType.Enum hashAlgorithm;
        public CiString issuerNameHash;
        public string issuerKeyHash;
        public CiString serialNumber;
        public CiString responderURL;
    }
}