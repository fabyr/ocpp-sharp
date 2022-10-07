using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "GetInstalledCertificateIds", OcppMessageAttribute.Direction.PointToCentral, addToMap: true)]
    public class GetInstalledCertificateIdsResponse : ResponsePayload
    {
        public GetInstalledCertificateStatusType.Enum status;
        public CertificateHashDataChain[]? certificateHashDataChain;
        public StatusInfo? statusInfo;
    }
}