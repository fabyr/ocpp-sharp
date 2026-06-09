using OcppSharp.Protocol.Version201.Types;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP201, OcppMessageAttribute.MessageType.Request, "CustomerInformation", OcppMessageAttribute.Direction.CentralToPoint)]
public class CustomerInformationRequest : RequestPayload
{
    [JsonPropertyName("requestId")]
    public long RequestId { get; set; }

    [JsonPropertyName("report")]
    public bool Report { get; set; }

    [JsonPropertyName("clear")]
    public bool Clear { get; set; }

    [JsonPropertyName("customerIdentifier")]
    public string? CustomerIdentifier { get; set; }

    [JsonPropertyName("idToken")]
    public IdToken? IdToken { get; set; }

    [JsonPropertyName("customerCertificate")]
    public CertificateHashData? CustomerCertificate { get; set; }
}
