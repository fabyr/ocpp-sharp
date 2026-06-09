namespace OcppSharp.Protocol;

public class Response
{
    // Defined within the OCPP protocol specification
    public const int MessageKind = 3;

    public string OriginalJsonBody { get; set; } = string.Empty;
    public ProtocolVersion ProtocolVersion { get; set; }

    public string MessageId { get; }

    public ResponsePayload? Payload { get; set; }

    public Response(string id)
    {
        MessageId = id;
    }
}
