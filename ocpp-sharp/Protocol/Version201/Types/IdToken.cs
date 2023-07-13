using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct IdToken
    {
        public static readonly IdToken Empty = new IdToken();

        public CiString idToken;
        public IdTokenType.Enum type;
        public AdditionalInfo[]? additionalInfo;
    }
}