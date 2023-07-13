using System;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.ResponsePayloads
{
    [OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "NotifyDisplayMessages", OcppMessageAttribute.Direction.CentralToPoint)]
    public class NotifyDisplayMessagesResponse : ResponsePayload
    {
    }
}