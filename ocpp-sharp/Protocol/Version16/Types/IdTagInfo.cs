using System;

namespace OcppSharp.Protocol.Version16.Types
{
    public struct IdTagInfo
    {
        public static readonly IdTagInfo Empty = new IdTagInfo();

        public DateTime? expiryDate;
        public CiString? parentIdTag;
        
        /// <summary>
        /// Valid Values in <see cref="OcppSharp.Protocol.MessageConstants.AuthorizationStatus"/>
        /// </summary>
        public MessageConstants.AuthorizationStatus.Enum status;
    }
}