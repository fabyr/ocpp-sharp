using OcppSharp.Protocol;

namespace OcppSharp.Server;

public delegate void ResponseHandlerDelegate(OcppSharpServer server, OcppClientConnection sender, Response response, string causeType);
public delegate void RequestHandlerDelegate(OcppSharpServer server, OcppClientConnection sender, Request request);



public delegate ResponsePayload RequestPayloadHandlerDelegate(OcppSharpServer server, OcppClientConnection sender, RequestPayload request);
public delegate ResponsePayload RequestPayloadHandlerDelegateGeneric<T>(OcppSharpServer server, OcppClientConnection sender, T request) where T : RequestPayload;


//Async handlers


public delegate Task ResponseHandlerDelegateAsync(OcppSharpServer server, OcppClientConnection sender, Response response, string causeType);
public delegate Task RequestHandlerDelegateAsync(OcppSharpServer server, OcppClientConnection sender, Request request);



public delegate Task<ResponsePayload> RequestPayloadHandlerDelegateAsync(OcppSharpServer server, OcppClientConnection sender, RequestPayload request);
public delegate Task<ResponsePayload> RequestPayloadHandlerDelegateGenericAsync<T>(OcppSharpServer server, OcppClientConnection sender, T request) where T : RequestPayload;
