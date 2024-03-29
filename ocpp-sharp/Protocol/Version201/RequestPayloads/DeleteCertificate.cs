using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "DeleteCertificate", OcppMessageAttribute.Direction.CentralToPoint)]
    public class DeleteCertificateRequest : RequestPayload
    {
        public CertificateHashData certificateHashData = CertificateHashData.Empty;

    }
}