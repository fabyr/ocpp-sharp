using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct AuthorizationData
    {
        public CiString idTag;
        public IdTagInfo? idTagInfo;
    }
}