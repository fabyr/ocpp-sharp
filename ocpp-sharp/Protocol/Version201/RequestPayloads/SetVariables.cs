using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetVariables", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class SetVariablesRequest : RequestPayload
    {
        /// <summary>
        /// Must contain atleast one element.
        /// </summary>
        public SetVariableData[] setVariableData = new SetVariableData[0];
        
    }
}