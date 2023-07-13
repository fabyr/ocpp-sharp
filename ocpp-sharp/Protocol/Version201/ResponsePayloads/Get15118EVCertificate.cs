using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "Get15118EVCertificate", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class Get15118EVCertificateResponse : ResponsePayload
    {
        public Iso15118EVCertificateStatusType.Enum status;
        public string exiResponse = string.Empty;
        public StatusInfo? statusInfo;
    }
}