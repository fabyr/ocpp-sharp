using OcppSharp.Protocol;

namespace OcppSharp.Client;

public delegate void ResponseHandlerDelegate(OcppSharpClient client, Response response, string causeType);
public delegate void RequestHandlerDelegate(OcppSharpClient client, Request request);

public delegate ResponsePayload RequestPayloadHandlerDelegate(OcppSharpClient client, RequestPayload request);
public delegate ResponsePayload RequestPayloadHandlerDelegateGeneric<T>(OcppSharpClient client, T request) where T : RequestPayload;
