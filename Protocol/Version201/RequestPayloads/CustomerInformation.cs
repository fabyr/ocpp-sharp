using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CustomerInformation", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class CustomerInformation : RequestPayload
    {
        public long requestId;
        public bool report;
        public bool clear;
        public string? customerIdentifier;
        public IdToken? idToken;
        public CertificateHashData? customerCertificate;

    }
}