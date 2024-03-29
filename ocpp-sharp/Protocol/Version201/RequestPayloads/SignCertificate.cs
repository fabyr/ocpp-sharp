using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SignCertificate", OcppMessageAttribute.Direction.PointToCentral)]
    public class SignCertificateRequest : RequestPayload
    {
        public string csr = string.Empty;
        public CertificateSigningUseType.Enum? certificateType;
    }
}