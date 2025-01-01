namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "MeterValues", OcppMessageAttribute.Direction.CentralToPoint)]
public class MeterValuesResponse : ResponsePayload
{
}
