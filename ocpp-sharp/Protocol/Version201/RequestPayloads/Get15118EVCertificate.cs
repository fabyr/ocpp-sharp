using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Get15118EVCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
    public class Get15118EVCertificateRequest : RequestPayload
    {
        public string iso15118SchemaVersion = string.Empty;
        public CertificateActionType.Enum action;
        public string exiRequest = string.Empty;

    }
}