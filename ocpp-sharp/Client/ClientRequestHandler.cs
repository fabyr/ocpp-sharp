using OcppSharp.Protocol;

namespace OcppSharp.Client;

public class ClientRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegate Handler { get; }

    public ClientRequestHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        OnType = payloadType;
        Handler = handler;
    }

    public ResponsePayload Handle(OcppSharpClient client, RequestPayload req)
    {
        return Handler(client, req);
    }
}
