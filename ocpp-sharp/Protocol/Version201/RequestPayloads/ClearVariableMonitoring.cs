using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ClearVariableMonitoring", OcppMessageAttribute.Direction.CentralToPoint)]
    public class ClearVariableMonitoringRequest : RequestPayload
    {
        public long[] id = new long[0];

    }
}