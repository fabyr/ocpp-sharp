using OcppSharp.Protocol;

namespace OcppSharp.Client;

public delegate void ResponseHandlerDelegate(OcppSharpClient client, Response resp, string causeType);
public delegate void RequestHandlerDelegate(OcppSharpClient client, Request req);

public delegate ResponsePayload RequestPayloadHandlerDelegate(OcppSharpClient client, RequestPayload req);
public delegate ResponsePayload RequestPayloadHandlerDelegateGeneric<T>(OcppSharpClient client, T req) where T : RequestPayload;
