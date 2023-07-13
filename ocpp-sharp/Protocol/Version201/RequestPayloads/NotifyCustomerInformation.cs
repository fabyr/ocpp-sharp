using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "NotifyCustomerInformation", OcppMessageAttribute.Direction.PointToCentral)]
    public class NotifyCustomerInformationRequest : RequestPayload
    {
        public string data = string.Empty;
        public bool? tbc;
        public int seqNo;
        public DateTime generatedAt;
        public long requestId;
        
    }
}