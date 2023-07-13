using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct CertificateHashData
    {
        public static readonly CertificateHashData Empty = new CertificateHashData();

        public HashAlgorithmType.Enum hashAlgorithm;
        public CiString issuerNameHash;
        public string issuerKeyHash;
        public CiString serialNumber;
    }
}