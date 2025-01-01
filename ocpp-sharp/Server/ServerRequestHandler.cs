using OcppSharp.Protocol;

namespace OcppSharp.Server;

public class ServerRequestHandler
{
    public Type OnType { get; }
    public RequestPayloadHandlerDelegate Handler { get; }

    private long Identity { get; }

    public ServerRequestHandler(Type t, RequestPayloadHandlerDelegate handler)
    {
        this.OnType = t;
        this.Handler = handler;
        Identity = Util.NewID64();
    }

    public ResponsePayload Handle(OcppSharpServer server, OcppClientConnection station, RequestPayload req)
    {
        return Handler(server, station, req);
    }

    public override int GetHashCode()
    {
        return (int)(Identity & int.MaxValue);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not ServerRequestHandler)
            return false;
        return ((ServerRequestHandler)obj).Identity == Identity;
    }
}
