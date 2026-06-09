namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "UpdateFirmware", OcppMessageAttribute.Direction.PointToCentral)]
public class UpdateFirmwareResponse : ResponsePayload
{
}
