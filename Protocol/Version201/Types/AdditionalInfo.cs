using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct AdditionalInfo
    {
        public static readonly AdditionalInfo Empty = new AdditionalInfo();

        public CiString additionalIdToken;
        public string type; // Custom type not defined in protocol
    }
}