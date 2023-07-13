using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetVariables", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetVariablesResponse : ResponsePayload
    {
        public GetVariableResult[] getVariableResult = new GetVariableResult[0];
    }
}