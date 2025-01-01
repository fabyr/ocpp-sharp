using OcppSharp.Protocol.Version16.Types;
using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "SendLocalList", OcppMessageAttribute.Direction.CentralToPoint)]
public class SendLocalListRequest : RequestPayload
{
    [JsonProperty("listVersion")]
    public long ListVersion { get; set; }

    [JsonProperty("localAuthorizationList")]
    public AuthorizationData[]? LocalAuthorizationList { get; set; }

    /// <summary>
    /// Valid values in <see cref="MessageConstants.UpdateType"/>
    /// </summary>
    [JsonProperty("updateType")]
    public UpdateType.Enum UpdateType { get; set; }
}
