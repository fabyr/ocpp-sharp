using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct IdTokenInfo
    {
        public static readonly IdTokenInfo Empty = new IdTokenInfo();

        public AuthorizationStatusType.Enum status;
        public DateTime? cacheExpiryDateTime;
        public int? chargingPriority;
        public string? language1;
        public int? evseId;
        public string? language2;
        public IdToken? groupIdToken;
        public MessageContent? personalMessage;
    }
}