namespace OcppSharp.Protocol;

public class Response
{
    public string BaseJson { get; set; } = string.Empty;
    public ProtocolVersion ProtocolVersion { get; set; }

    public int MessageKind { get; private set; }
    public string MessageId { get; private set; }

    public ResponsePayload? Payload { get; set; }

    public Response(int kind, string id)
    {
        MessageKind = kind;
        MessageId = id;
    }
}
