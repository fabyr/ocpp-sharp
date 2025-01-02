namespace OcppSharp.Protocol;

public class Request
{
    // Defined within the OCPP protocol specification
    public const int MessageKind = 2;

    public string OriginalJsonBody { get; set; } = string.Empty;
    public ProtocolVersion ProtocolVersion { get; set; }

    public string MessageId { get; }
    public string MessageType { get; }

    public RequestPayload? Payload { get; set; }

    public Request(string id, string type)
    {
        MessageId = id;
        MessageType = type;
    }
}
