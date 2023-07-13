using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct CertificateHashDataChain
    {
        public static readonly CertificateHashDataChain Empty = new CertificateHashDataChain();

        public GetCertificateIdUseType.Enum certificateType;
        public CertificateHashData certificateHashData;

        /// <summary>
        /// Array length must not exceed 4.
        /// </summary>
        public CertificateHashData[]? childCertificateHashData;
    }
}