using OcppSharp.Protocol;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Reflection;
using System.Diagnostics;

namespace OcppSharp;

public static class OcppJson
{
    private static readonly Dictionary<ProtocolVersion, Dictionary<CiString, Type>> messageRequestTypeMap; // Requests from Station
    private static readonly Dictionary<ProtocolVersion, Dictionary<CiString, Type>> messageResponseTypeMap; // Responses from Station

    static OcppJson()
    {
        messageRequestTypeMap = [];
        messageResponseTypeMap = [];

        ProtocolVersion[] versions = Enum.GetValues<ProtocolVersion>();
        foreach (ProtocolVersion version in versions)
        {
            messageRequestTypeMap.Add(version, []);
            messageResponseTypeMap.Add(version, []);
        }

        Assembly currentAssembly = Assembly.GetExecutingAssembly();

        // Scan the assembly for Types defining "[OcppMessage(...)]" and add them to the dictionaries
        foreach (Type type in currentAssembly.GetTypes())
        {
            OcppMessageAttribute? attr = type.GetCustomAttributes<OcppMessageAttribute>(true).FirstOrDefault();
            if (attr != null)
            {
                switch (attr.MsgType)
                {
                    case OcppMessageAttribute.MessageType.Request:
                        messageRequestTypeMap[attr.Version].Add(attr.Name, type);
                        break;
                    case OcppMessageAttribute.MessageType.Response:
                        messageResponseTypeMap[attr.Version].Add(attr.Name, type);
                        break;
                }
            }
        }
    }

    public static bool IsRequest(string json)
    {
        JArray array = JArray.Parse(json);
        int messageKind = array[0].ToObject<int>();
        return messageKind == Request.MessageKind;
    }

    private static Dictionary<CiString, Type> GetMap(ProtocolVersion version, bool responseMap)
    {
        return (responseMap ? messageResponseTypeMap : messageRequestTypeMap)[version];
    }

    private static Type GetMessageType(ProtocolVersion version, bool responseMap, CiString key)
    {
        return GetMap(version, responseMap)[key];
    }

    // Decodes a Request JSON to the corresponding object, always of base type Request
    public static Request DecodeRequest(string json, ProtocolVersion version)
    {
        JArray array = JArray.Parse(json);
        string messageType = array[2].ToObject<string>() ?? throw new Exception();
        string messageId = array[1].ToObject<string>() ?? throw new Exception();

        Debug.Assert(array[0].ToObject<int>() == Request.MessageKind, "Invalid Message Header for Request");

        Request req = new(messageId, messageType);

        JsonSerializer serializer = new();

        req.Payload = (RequestPayload?)array[3].ToObject(GetMessageType(version, false, messageType), serializer);
        if (req.Payload == null)
            throw new FormatException("Failed to parse request payload.");
        req.Payload.FullRequest = req;
        req.ProtocolVersion = version;

        return req;
    }

    /// <summary>
    /// Parses the "header" of the Response to a Response Object.
    /// This means that the Payload won't be parsed and needs to be handled seperately.
    /// </summary>
    public static Response DecodeResponseCrude(string json, ProtocolVersion version)
    {
        JArray array = JArray.Parse(json);
        string messageId = array[1].ToObject<string>() ?? throw new Exception();

        Debug.Assert(array[0].ToObject<int>() == Response.MessageKind, "Invalid Message Header for Response");

        Response resp = new(messageId)
        {
            ProtocolVersion = version
        };
        return resp;
    }

    /// <summary>
    /// Parses the rest of an unfinished response parsed by DecodeResponseCrude.
    /// It directly modifies the reference of the supplied crudeResponse.
    /// </summary>
    /// <param name="requestMessageType">Since a response does not contain the type of request it originates from, <br/>this parameter needs to be supplied for proper parsing.</param>
    public static void DecodeResponseFull(Response crudeResponse, string requestMessageType)
    {
        JArray array = JArray.Parse(crudeResponse.OriginalJsonBody);

        JsonSerializer serializer = new();

        crudeResponse.Payload = (ResponsePayload?)array[2].ToObject(GetMessageType(crudeResponse.ProtocolVersion, true, requestMessageType), serializer);
        if (crudeResponse.Payload != null)
            crudeResponse.Payload.FullResponse = crudeResponse;
    }

    // Serialize Response object to JSON
    public static string SerializeResponse(Response resp)
    {
        object?[] array = [
            Response.MessageKind,
            resp.MessageId,
            resp.Payload
        ];

        JsonSerializerSettings jsonSerializerSettings = new()
        {
            TypeNameHandling = TypeNameHandling.None,
            NullValueHandling = NullValueHandling.Ignore
        };

        string json = JsonConvert.SerializeObject(array, jsonSerializerSettings);
        return json;
    }

    // Serialize Request object to JSON
    public static string SerializeRequest(Request req)
    {
        object?[] array = [
            Request.MessageKind,
            req.MessageId,
            req.MessageType,
            req.Payload
        ];

        JsonSerializerSettings jsonSerializerSettings = new()
        {
            TypeNameHandling = TypeNameHandling.None,
            NullValueHandling = NullValueHandling.Ignore
        };

        return JsonConvert.SerializeObject(array, jsonSerializerSettings);
    }
}
