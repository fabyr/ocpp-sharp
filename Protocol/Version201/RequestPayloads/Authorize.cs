using System;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "Authorize", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class Authorize : RequestPayload
    {
        public string? certificate;
        public IdToken idToken = IdToken.Empty;
        public OCSPRequestData iso15118CertificateHashData = OCSPRequestData.Empty;

    }
}