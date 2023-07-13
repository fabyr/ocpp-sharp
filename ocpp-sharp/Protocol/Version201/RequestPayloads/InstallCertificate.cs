using System;
using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;

namespace OcppSharp.Protocol.Version201.RequestPayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "InstallCertificate", OcppMessageAttribute.Direction.CentralToPoint, addToMap: false)]
    public class InstallCertificateRequest : RequestPayload
    {
        public InstallCertificateUseType.Enum certificateType;
        public string certificate = string.Empty;
        
    }
}