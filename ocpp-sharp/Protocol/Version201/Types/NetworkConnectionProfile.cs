using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct NetworkConnectionProfile
{
    public static readonly NetworkConnectionProfile Empty = new();

    [JsonProperty("ocppVersion")]
    public OCPPVersionType.Enum OcppVersion { get; set; }

    [JsonProperty("ocppTransport")]
    public OCPPTransportType.Enum OcppTransport { get; set; }

    [JsonProperty("ocppCsmsUrl")]
    public string OcppCsmsUrl { get; set; }

    [JsonProperty("messageTimeout")]
    public int MessageTimeout { get; set; }

    [JsonProperty("securityProfile")]
    public int SecurityProfile { get; set; }

    [JsonProperty("ocppInterface")]
    public OCPPInterfaceType.Enum OcppInterface { get; set; }

    [JsonProperty("vpn")]
    public VPN? Vpn { get; set; }

    [JsonProperty("apn")]
    public APN? Apn { get; set; }
}
