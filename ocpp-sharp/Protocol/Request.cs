namespace OcppSharp.Protocol;

public class Request
{
    public string BaseJson { get; set; } = string.Empty;
    public ProtocolVersion ProtocolVersion { get; set; }

    public int MessageKind { get; private set; }
    public string MessageId { get; private set; }
    public string MessageType { get; private set; }

    public RequestPayload? Payload { get; set; }

    public Request(int kind, string id, string type)
    {
        MessageKind = kind;
        MessageId = id;
        MessageType = type;
    }
}
