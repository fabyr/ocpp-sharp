using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "SetNetworkProfile", OcppMessageAttribute.Direction.CentralToPoint)]
public class SetNetworkProfileRequest : RequestPayload
{
    [JsonProperty("configurationSlot")]
    public int ConfigurationSlot { get; set; }

    [JsonProperty("connectionData")]
    public NetworkConnectionProfile ConnectionData { get; set; }
}
