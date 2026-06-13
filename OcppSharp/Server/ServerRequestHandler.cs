using OcppSharp.Protocol;

namespace OcppSharp.Server;

public class ServerRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegateAsync Handler { get; }

    public ServerRequestHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        OnType = payloadType;
        Handler = (server, sender, request) =>
        {
            return Task.FromResult(handler(server, sender, request));
        };
    }

    public ServerRequestHandler(Type payloadType, RequestPayloadHandlerDelegateAsync handlerAsync)
    {
        OnType = payloadType;
        Handler = handlerAsync;
    }

    public Task<ResponsePayload> HandleAsync(OcppSharpServer server, OcppClientConnection station, RequestPayload request)
    {
        return Handler(server, station, request);
    }
}
