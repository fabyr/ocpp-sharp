using System;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetDiagnostics", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class GetDiagnosticsResponse : ResponsePayload
    {
        public CiString? fileName;
        
    }
}