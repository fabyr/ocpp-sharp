using System.Text.Json.Serialization;
using OcppSharp.Protocol.Version16.Types;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetConfiguration", OcppMessageAttribute.Direction.PointToCentral)]
public class GetConfigurationResponse : ResponsePayload
{
    [JsonPropertyName("configurationKey")]
    public KeyValue[]? ConfigurationKey { get; set; }

    [JsonPropertyName("unknownKey")]
    public CiString[]? UnknownKey { get; set; }

    public KeyValue? this[string key]
    {
        get
        {
            return ConfigurationKey?.FirstOrDefault(x => Equals(x.Key, key));
        }
    }
}
