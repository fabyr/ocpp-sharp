using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.MessageConstants;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SendLocalList", OcppMessageAttribute.Direction.CentralToPoint)]
public class SendLocalListRequest : RequestPayload
{
    [JsonPropertyName("versionNumber")]
    public int VersionNumber { get; set; }

    [JsonPropertyName("updateType")]
    public UpdateType.Enum UpdateType { get; set; }

    [JsonPropertyName("localAuthorizationList")]
    public AuthorizationData[]? LocalAuthorizationList { get; set; }
}
