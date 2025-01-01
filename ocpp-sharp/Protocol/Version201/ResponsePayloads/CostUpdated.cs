namespace OcppSharp.Protocol.Version201.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Response, "CostUpdated", OcppMessageAttribute.Direction.PointToCentral)]
public class CostUpdatedResponse : ResponsePayload
{
}
