using OcppSharp.Protocol.Version201.Types;
using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SendLocalList", OcppMessageAttribute.Direction.CentralToPoint)]
public class SendLocalListRequest : RequestPayload
{
    [JsonProperty("versionNumber")]
    public int VersionNumber { get; set; }

    [JsonProperty("updateType")]
    public UpdateType.Enum UpdateType { get; set; }

    [JsonProperty("localAuthorizationList")]
    public AuthorizationData[]? LocalAuthorizationList { get; set; }
}
