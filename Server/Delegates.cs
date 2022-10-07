using System;
using OcppSharp.Protocol;

namespace OcppSharp.Server
{
    public delegate void ResponseHandlerDelegate(OcppSharpServer server, OcppClientConnection sender, Response resp, string causeType);
    
    public delegate void RequestHandlerDelegate(OcppSharpServer server, OcppClientConnection sender, Request req);
    
    public delegate ResponsePayload RequestPayloadHandlerDelegate(OcppSharpServer server, OcppClientConnection sender, RequestPayload req);
    public delegate ResponsePayload RequestPayloadHandlerDelegateGeneric<T>(OcppSharpServer server, OcppClientConnection sender, T req) where T : RequestPayload;
}