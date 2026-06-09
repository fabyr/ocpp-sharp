using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "RequestStartTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RequestStartTransactionRequest : RequestPayload
{
    [JsonPropertyName("evseId")]
    public long? EvseId { get; set; }

    [JsonPropertyName("remoteStartId")]
    public long RemoteStartId { get; set; }

    [JsonPropertyName("idToken")]
    public IdToken IdToken { get; set; }

    [JsonPropertyName("chargingProfile")]
    public ChargingProfile? ChargingProfile { get; set; }

    [JsonPropertyName("groupIdToken")]
    public IdToken? GroupIdToken { get; set; }
}
