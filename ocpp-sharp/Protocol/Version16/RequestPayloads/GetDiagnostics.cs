using System;

namespace OcppSharp.Protocol.Version16.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "GetDiagnostics", OcppMessageAttribute.Direction.CentralToPoint)]
    public class GetDiagnosticsRequest : RequestPayload
    {
        public string location = string.Empty;
        public long? retries;
        public long? retryInterval;
        public DateTime? startTime;
        public DateTime? stopTime;

    }
}