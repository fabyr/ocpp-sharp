using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetVariables", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class SetVariablesResponse : ResponsePayload
    {
        /// <summary>
        /// Must contain atleast one element.
        /// </summary>
        public SetVariableResult[] setVariableResult = new SetVariableResult[0];
    }
}