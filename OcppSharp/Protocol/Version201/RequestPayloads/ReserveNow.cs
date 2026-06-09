using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "ReserveNow", OcppMessageAttribute.Direction.CentralToPoint)]
public class ReserveNowRequest : RequestPayload
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("expiryDateTime")]
    public DateTime ExpiryDateTime { get; set; }

    [JsonPropertyName("connectorType")]
    public ConnectorType.Enum ConnectorType { get; set; }

    [JsonPropertyName("evseId")]
    public long EvseId { get; set; }

    [JsonPropertyName("idToken")]
    public IdToken IdToken { get; set; }

    [JsonPropertyName("groupIdToken")]
    public IdToken GroupIdToken { get; set; }
}
