using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "GetCertificateStatus", OcppMessageAttribute.Direction.PointToCentral)]
    public class GetCertificateStatusRequest : RequestPayload
    {
        public OCSPRequestData ocspRequestData = OCSPRequestData.Empty;

    }
}