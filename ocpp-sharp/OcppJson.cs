using OcppSharp.Protocol;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Reflection;

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

        // Scan the assembly for Types having a "[OcppMessage(...)]", and add the appropriate ones to the dictionaries
        foreach (Type type in currentAssembly.GetTypes())
        {
            OcppMessageAttribute[] attrs;
            if ((attrs = (OcppMessageAttribute[])type.GetCustomAttributes(typeof(OcppMessageAttribute), true)).Length == 1)
            {
                OcppMessageAttribute attr = attrs[0];

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

    public static string? GetStringValue(Enum? e)
    {
        if (e == null)
            return null;
        StringValueAttribute? attr = null;
        if ((attr = e.GetAttributeOfType<StringValueAttribute>()) != null)
        {
            return attr.Text;
        }
        return e.ToString();
    }

    public static T? GetEnumValue<T>(string stringValue) where T : Enum
    {
        return (T?)GetEnumValue(stringValue, typeof(T));
    }

    public static Enum? GetEnumValue(string stringValue, Type enumType)
    {
        var values = Enum.GetValues(enumType).Cast<Enum>();

        foreach (Enum value in values)
        {
            CiString? compare = value.GetAttributeOfType<StringValueAttribute>()?.Text ?? value.ToString();
            if (compare == stringValue)
            {
                return value;
            }
        }
        return null;
    }

    public static string SerializeObject(object? obj, bool humanReadable = false)
    {
        JsonSerializerSettings jsonSerializerSettings = new()
        {
            TypeNameHandling = TypeNameHandling.None,
            NullValueHandling = NullValueHandling.Ignore
        };
        if (humanReadable)
            jsonSerializerSettings.Formatting = Formatting.Indented;

        string json = JsonConvert.SerializeObject(obj, jsonSerializerSettings);
        return json;
    }

    public static T? DeserializeObject<T>(string json)
    {
        JsonSerializerSettings jsonSerializerSettings = new()
        {
            TypeNameHandling = TypeNameHandling.None,
            NullValueHandling = NullValueHandling.Ignore
        };

        return JsonConvert.DeserializeObject<T>(json, jsonSerializerSettings);
    }

    public static bool IsRequest(string json)
    {
        JArray array = JArray.Parse(json);
        int messageKind = array[0].ToObject<int>();
        return messageKind == 2;// && messageRequestTypeMap.ContainsKey(array[2].ToObject<string>());
    }

    private static Dictionary<CiString, Type> GetMap(ProtocolVersion version, bool responseMap)
    {
        return responseMap ? messageResponseTypeMap[version] : messageRequestTypeMap[version];
    }

    // Decodes a Request JSON to the corresponding object, always of base type Request
    public static Request DecodeRequest(string json, ProtocolVersion version)
    {
        JArray array = JArray.Parse(json);
        string messageType = array[2].ToObject<string>() ?? throw new Exception();
        string messageId = array[1].ToObject<string>() ?? throw new Exception();
        Request req = new(array[0].ToObject<int>(), messageId, messageType);

        JsonSerializer jse = new();

        req.Payload = (RequestPayload?)array[3].ToObject(GetMap(version, false)[messageType], jse);
        if (req.Payload != null) req.Payload.FullRequest = req;
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
        Response resp = new(array[0].ToObject<int>(), messageId)
        {
            ProtocolVersion = version
        };
        return resp;
    }

    /// <summary>
    /// Parses the rest of an unfinished response parsed by DecodeResponseCrude.
    /// It directly modifies the reference of the supplied crudeResponse.
    /// </summary>
    /// <param name="requestMessageType">Since a response does not contain the type of request it originates from, <br/>this needs to be supplied for proper parsing.</param>
    public static void DecodeResponseFull(Response crudeResponse, string requestMessageType)
    {
        JArray array = JArray.Parse(crudeResponse.BaseJson);

        JsonSerializer jse = new();

        crudeResponse.Payload = (ResponsePayload?)array[2].ToObject(GetMap(crudeResponse.ProtocolVersion, true)[requestMessageType], jse);
        if (crudeResponse.Payload != null) crudeResponse.Payload.FullResponse = crudeResponse;
    }

    // Serialize Response object to JSON
    public static string SerializeResponse(Response resp)
    {
        object?[] array =
        [
            resp.MessageKind,
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
        object?[] array =
        [
            req.MessageKind,
            req.MessageId,
            req.MessageType,
            req.Payload
        ];

        JsonSerializerSettings jsonSerializerSettings = new()
        {
            TypeNameHandling = TypeNameHandling.None,
            NullValueHandling = NullValueHandling.Ignore
        };

        string json = JsonConvert.SerializeObject(array, jsonSerializerSettings);
        return json;
    }
}
