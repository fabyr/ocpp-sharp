using OcppSharp.Protocol.Version16.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.ResponsePayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Response, "GetConfiguration", OcppMessageAttribute.Direction.PointToCentral)]
public class GetConfigurationResponse : ResponsePayload
{
    [JsonProperty("configurationKey")]
    public KeyValue[]? ConfigurationKey { get; set; }

    [JsonProperty("unknownKey")]
    public CiString[]? UnknownKey { get; set; }

    public KeyValue? this[string key]
    {
        get
        {
            return ConfigurationKey?.FirstOrDefault(x => Equals(x.Key, key));
        }
    }
}
