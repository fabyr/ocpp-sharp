using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ReserveNow", OcppMessageAttribute.Direction.CentralToPoint)]
public class ReserveNowRequest : RequestPayload
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("expiryDateTime")]
    public DateTime ExpiryDateTime { get; set; }

    [JsonProperty("connectorType")]
    public ConnectorType.Enum ConnectorType { get; set; }

    [JsonProperty("evseId")]
    public long EvseId { get; set; }

    [JsonProperty("idToken")]
    public IdToken IdToken { get; set; }

    [JsonProperty("groupIdToken")]
    public IdToken GroupIdToken { get; set; }
}
