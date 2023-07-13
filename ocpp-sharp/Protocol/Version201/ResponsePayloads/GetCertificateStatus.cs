using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetCertificateStatus", OcppMessageAttribute.Direction.CentralToPoint)]
    public class GetCertificateStatusResponse : ResponsePayload
    {
        public GetCertificateStatusType.Enum status;
        public string? ocspResult;
        public StatusInfo? statusInfo;
    }
}