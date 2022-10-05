using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "ClearVariableMonitoring", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class ClearVariableMonitoring : ResponsePayload
    {
        public ClearMonitoringResult[] clearMonitoringResult = new ClearMonitoringResult[0];
    }
}