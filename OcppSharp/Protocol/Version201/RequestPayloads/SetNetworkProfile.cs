using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version201.Types;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetNetworkProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetNetworkProfileRequest : RequestPayload
{
    [JsonPropertyName("configurationSlot")]
    public int ConfigurationSlot { get; set; }

    [JsonPropertyName("connectionData")]
    public NetworkConnectionProfile ConnectionData { get; set; }
}
