using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "SendLocalList", OcppMessageAttribute.Direction.CentralToPoint)]
public class SendLocalListRequest : RequestPayload
{
    [JsonPropertyName("listVersion")]
    public long ListVersion { get; set; }

    [JsonPropertyName("localAuthorizationList")]
    public AuthorizationData[]? LocalAuthorizationList { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.UpdateType"/>
    /// </summary>
    [JsonPropertyName("updateType")]
    public UpdateType.Enum UpdateType { get; set; }
}
