using OcppSharp.Protocol.Version201.Types;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CustomerInformation", OcppMessageAttribute.Direction.CentralToPoint)]
public class CustomerInformationRequest : RequestPayload
{
    [JsonProperty("requestId")]
    public long RequestId { get; set; }

    [JsonProperty("report")]
    public bool Report { get; set; }

    [JsonProperty("clear")]
    public bool Clear { get; set; }

    [JsonProperty("customerIdentifier")]
    public string? CustomerIdentifier { get; set; }

    [JsonProperty("idToken")]
    public IdToken? IdToken { get; set; }

    [JsonProperty("customerCertificate")]
    public CertificateHashData? CustomerCertificate { get; set; }
}
