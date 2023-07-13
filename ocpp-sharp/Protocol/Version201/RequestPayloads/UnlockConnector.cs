using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "UnlockConnector", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class UnlockConnectorRequest : RequestPayload
    {
        public long evseId;
        public long connectorId;
        
    }
}