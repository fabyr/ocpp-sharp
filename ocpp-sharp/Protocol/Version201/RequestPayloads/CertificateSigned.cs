using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CertificateSigned", OcppMessageAttribute.Direction.CentralToPoint)]
    public class CertificateSignedRequest : RequestPayload
    {
        public string certificateChain = string.Empty;
        public CertificateSigningUseType.Enum certificateType;

    }
}