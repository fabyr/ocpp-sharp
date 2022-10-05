using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetVariables", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class GetVariables : RequestPayload
    {
        public GetVariableData[] getVariableData = new GetVariableData[0];
    }
}