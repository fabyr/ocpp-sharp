using OcppSharp.Protocol;

namespace OcppSharp.Client;

public class ClientRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegate? Handler { get; } = null;
    public RequestPayloadHandlerDelegateAsync? HandlerAsync { get; } = null;

    public ClientRequestHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        OnType = payloadType;
        Handler = handler;
    }

    public ClientRequestHandler(Type payloadType, RequestPayloadHandlerDelegateAsync handlerAsync)
    {
        OnType = payloadType;
        HandlerAsync = handlerAsync;
    }

    public async Task<ResponsePayload> HandleAsync(OcppSharpClient client, RequestPayload request)
    {
        if (Handler == null)
        {
            if (HandlerAsync == null)
            {
                throw new InvalidOperationException("No handler is set for this request type.");
            }
            return await HandlerAsync(client, request);
        }
        return Handler(client, request);
    }
}
