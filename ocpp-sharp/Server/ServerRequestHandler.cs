using OcppSharp.Protocol;

namespace OcppSharp.Server;

public class ServerRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegate Handler { get; }

    public ServerRequestHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        OnType = payloadType;
        Handler = handler;
    }

    public ResponsePayload Handle(OcppSharpServer server, OcppClientConnection station, RequestPayload req)
    {
        return Handler(server, station, req);
    }
}
