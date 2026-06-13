using OcppSharp.Protocol;

namespace OcppSharp.Client;

public class ClientRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegateAsync Handler { get; }

    public ClientRequestHandler(Type payloadType, RequestPayloadHandlerDelegate handler)
    {
        OnType = payloadType;
        Handler = (client, request) =>
        {
            return Task.FromResult(handler(client, request));
        };
    }

    public ClientRequestHandler(Type payloadType, RequestPayloadHandlerDelegateAsync handlerAsync)
    {
        OnType = payloadType;
        Handler = handlerAsync;
    }

    public Task<ResponsePayload> HandleAsync(OcppSharpClient client, RequestPayload request)
    {
        return Handler(client, request);
    }
}
