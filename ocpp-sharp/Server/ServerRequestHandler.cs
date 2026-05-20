using OcppSharp.Protocol;

namespace OcppSharp.Server;

public class ServerRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegate? Handler { get; } = null;
    public RequestPayloadHandlerDelegateAsync? HandlerAsync { get; } = null;


    public ServerRequestHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        OnType = payloadType;
        Handler = handler;
    }

    public ServerRequestHandler(Type payloadType, RequestPayloadHandlerDelegateAsync handlerAsync)
    {
        OnType = payloadType;
        HandlerAsync = handlerAsync;
    }

    public async Task<ResponsePayload> HandleAsync(OcppSharpServer server, OcppClientConnection station, RequestPayload request)
    {
        if (Handler == null)
        {
            if (HandlerAsync == null)
            {
                throw new InvalidOperationException("No handler is set for this request type.");
            }
            return await HandlerAsync(server, station, request);
        }
        return Handler(server, station, request);
    }
}
