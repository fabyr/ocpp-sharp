using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetVariableMonitoring", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class SetVariableMonitoringRequest : RequestPayload
    {
        /// <summary>
        /// Must contain atleast one element.
        /// </summary>
        public SetMonitoringData[] setMonitoringData = new SetMonitoringData[0];
        
    }
}