using OcppSharp.Protocol;

namespace OcppSharp.Client;

public class ClientRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegate Handler { get; }

    private long Identity { get; }

    public ClientRequestHandler(Type t, RequestPayloadHandlerDelegate handler)
    {
        this.OnType = t;
        this.Handler = handler;
        Identity = Util.NewID64();
    }

    public ResponsePayload Handle(OcppSharpClient client, RequestPayload req)
    {
        return Handler(client, req);
    }

    public override int GetHashCode()
    {
        return (int)(Identity & int.MaxValue);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not ClientRequestHandler)
            return false;
        return ((ClientRequestHandler)obj).Identity == Identity;
    }
}
