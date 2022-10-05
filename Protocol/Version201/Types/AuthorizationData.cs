using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct AuthorizationData
    {
        public static readonly AuthorizationData Empty = new AuthorizationData();

        public IdTokenInfo? idTokenInfo;
        public IdToken idToken;
    }
}