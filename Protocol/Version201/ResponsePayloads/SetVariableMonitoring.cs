using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "SetVariableMonitoring", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class SetVariableMonitoringResponse : ResponsePayload
    {
        /// <summary>
        /// Must contain atleast one element.
        /// </summary>
        public SetMonitoringResult[] setMonitoringResult = new SetMonitoringResult[0];
    }
}