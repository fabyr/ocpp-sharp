using OcppSharp.Protocol.Version201.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.Types;

public struct NetworkConnectionProfile
{
    public static readonly NetworkConnectionProfile Empty = new();

    [JsonPropertyName("ocppVersion")]
    public OCPPVersionType.Enum OcppVersion { get; set; }

    [JsonPropertyName("ocppTransport")]
    public OCPPTransportType.Enum OcppTransport { get; set; }

    [JsonPropertyName("ocppCsmsUrl")]
    public string OcppCsmsUrl { get; set; }

    [JsonPropertyName("messageTimeout")]
    public int MessageTimeout { get; set; }

    [JsonPropertyName("securityProfile")]
    public int SecurityProfile { get; set; }

    [JsonPropertyName("ocppInterface")]
    public OCPPInterfaceType.Enum OcppInterface { get; set; }

    [JsonPropertyName("vpn")]
    public VPN? Vpn { get; set; }

    [JsonPropertyName("apn")]
    public APN? Apn { get; set; }
}
