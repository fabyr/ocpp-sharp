using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "RequestStartTransaction", OcppMessageAttribute.Direction.CentralToPoint)]
public class RequestStartTransactionRequest : RequestPayload
{
    [JsonProperty("evseId")]
    public long? EvseId { get; set; }

    [JsonProperty("remoteStartId")]
    public long RemoteStartId { get; set; }

    [JsonProperty("idToken")]
    public IdToken IdToken { get; set; }

    [JsonProperty("chargingProfile")]
    public ChargingProfile? ChargingProfile { get; set; }

    [JsonProperty("groupIdToken")]
    public IdToken? GroupIdToken { get; set; }
}
