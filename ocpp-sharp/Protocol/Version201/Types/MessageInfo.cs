using System;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.Types
{
    public struct MessageInfo
    {
        public static readonly MessageInfo Empty = new MessageInfo();

        public long id;
        public MessagePriorityType.Enum priority;
        public MessageStateType.Enum? state;
        public DateTime? startDateTime;
        public DateTime? endDateTime;
        public CiString? transactionId;
        public MessageContent message;
    }
}