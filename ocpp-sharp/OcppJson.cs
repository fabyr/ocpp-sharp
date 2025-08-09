using OcppSharp.Protocol;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OcppSharp;

public static class OcppJson
{
    // Default settings for all OCPP related json encode and decode operations
    private static readonly JsonSerializerOptions jsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip,
        NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.AllowNamedFloatingPointLiterals,
        ReferenceHandler = ReferenceHandler.IgnoreCycles,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    private static readonly Dictionary<ProtocolVersion, Dictionary<CiString, Type>> messageRequestTypeMap; // OCPP request classes
    private static readonly Dictionary<ProtocolVersion, Dictionary<CiString, Type>> messageResponseTypeMap; // OCPP response classes

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
            OcppMessageAttribute? attr = type.GetCustomAttribute<OcppMessageAttribute>();
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

    private static Dictionary<CiString, Type> GetMap(ProtocolVersion version, bool responseMap)
    {
        return (responseMap ? messageResponseTypeMap : messageRequestTypeMap)[version];
    }

    private static Type GetMessageType(ProtocolVersion version, bool responseMap, CiString key)
    {
        if (GetMap(version, responseMap).TryGetValue(key, out Type? value))
        {
            return value;
        }

        throw new KeyNotFoundException($"No OCPP protocol class for message type '{key}'");
    }

    /// <summary>
    /// Determines if a raw ocpp json message is a request.
    /// </summary>
    /// <param name="json">The raw ocpp json message.</param>
    /// <returns>true, if the message is a request; false, otherwise.</returns>
    /// <exception cref="FormatException">If the json string cannot be parsed as it is malformed.</exception>
    public static bool IsRequest(string json)
    {
        using JsonDocument array = JsonDocument.Parse(json);
        if (array.RootElement.GetArrayLength() < 1)
            throw new FormatException("Empty header structure.");
        int messageKind = array.RootElement[0].GetInt32();

        return messageKind == Request.MessageKind;
    }

    /// <summary>
    /// Parses an ocpp request message and returns a request object.
    /// </summary>
    /// <param name="json">The raw ocpp json message.</param>
    /// <param name="version">The ocpp protocol version of this message.</param>
    /// <returns>A request object with parsed header information and a parsed request payload.</returns>
    /// <exception cref="FormatException">If the json string cannot be parsed as it is malformed.</exception>
    public static Request DecodeRequest(string json, ProtocolVersion version)
    {
        using JsonDocument array = JsonDocument.Parse(json);

        string messageType = array.RootElement[2].GetString() ?? throw new FormatException("Malformed message header: missing message type");
        string messageId = array.RootElement[1].GetString() ?? throw new FormatException("Malformed message header: missing message id");

        if (array.RootElement.GetArrayLength() != 4)
            throw new FormatException("Invalid length for message header");

        if (array.RootElement[0].GetInt32() != Request.MessageKind)
            throw new FormatException("Invalid message header magic number for request");

        Request request = new(messageId, messageType);

        RequestPayload payload = (RequestPayload?)array.RootElement[3].Deserialize(GetMessageType(version, false, messageType), jsonSerializerOptions)
                                    ?? throw new FormatException("Failed to parse request payload.");

        request.Payload = payload;
        request.Payload.FullRequest = request;
        request.ProtocolVersion = version;

        return request;
    }

    /// <summary>
    /// Determines if a raw ocpp json message is a response.
    /// </summary>
    /// <param name="json">The raw ocpp json message.</param>
    /// <returns>true, if the message is a response; false, otherwise.</returns>
    /// <exception cref="JsonException">If the json string cannot be parsed as it is malformed.</exception>
    /// <exception cref="FormatException">If the header has an invalid structure.</exception>
    public static bool IsResponse(string json)
    {
        using JsonDocument document = JsonDocument.Parse(json);
        JsonElement array = document.RootElement;

        if (array.GetArrayLength() < 1)
            throw new FormatException("Empty header structure.");

        int messageKind = array[0].GetInt32();

        return messageKind == Response.MessageKind;
    }

    /// <summary>
    /// Parses the "header" of a response and returns a response object.
    /// This means that the Payload won't be parsed and needs to be handled separately.
    /// </summary>
    /// <param name="json">The raw ocpp json message.</param>
    /// <param name="version">The ocpp protocol version of this message.</param>
    /// <returns>A response object with parsed header information but no payload.</returns>
    /// <exception cref="JsonException">If the json string cannot be parsed as it is malformed.</exception>
    /// <exception cref="FormatException">If the header has an invalid structure.</exception>
    public static Response DecodeResponseCrude(string json, ProtocolVersion version)
    {
        using JsonDocument document = JsonDocument.Parse(json);
        JsonElement array = document.RootElement;

        if (array.GetArrayLength() != 3)
            throw new FormatException("Invalid length for message header");

        if (array[0].GetInt32() != Response.MessageKind)
            throw new FormatException("Invalid message header magic number for response");

        string messageId = array[1].GetString() ?? throw new FormatException("Malformed message header: missing message id");

        Response response = new(messageId)
        {
            ProtocolVersion = version
        };

        return response;
    }

    /// <summary>
    /// Parses the rest of an unfinished response parsed by <see cref="DecodeResponseCrude"/>.
    /// <para>It directly modifies the response object and extends it with the missing payload.</para>
    /// </summary>
    /// <param name="crudeResponse">A response object produced by a call to <see cref="DecodeResponseCrude"/>, which will be modified.</param>
    /// <param name="requestMessageType">Since a response does not contain the type of request it originates from, <br/>this parameter needs to be supplied for proper parsing.</param>
    /// <exception cref="JsonException">If the json string cannot be parsed as it is malformed or does not conform to the payload type.</exception>
    /// <exception cref="FormatException">Payload is null.</exception>
    public static void DecodeResponseFull(Response crudeResponse, string requestMessageType)
    {
        using JsonDocument document = JsonDocument.Parse(crudeResponse.OriginalJsonBody);
        JsonElement array = document.RootElement;

        ResponsePayload payload = (ResponsePayload?)array[2].Deserialize(GetMessageType(crudeResponse.ProtocolVersion, true, requestMessageType), jsonSerializerOptions)
                                    ?? throw new FormatException("Failed to parse response payload.");
        payload.FullResponse = crudeResponse;

        crudeResponse.Payload = payload;
    }

    /// <summary>
    /// Serialize a response object to JSON, ready to be sent as a websocket message.
    /// </summary>
    /// <param name="response">The response object to be serialized.</param>
    /// <returns>The serialized json string.</returns>
    public static string SerializeResponse(Response response)
    {
        object?[] array = [
            Response.MessageKind,
            response.MessageId,
            response.Payload
        ];

        return JsonSerializer.Serialize(array, jsonSerializerOptions);
    }

    /// <summary>
    /// Serialize a request object to JSON, ready to be sent as a websocket message.
    /// </summary>
    /// <param name="request">The request object to be serialized.</param>
    /// <returns>The serialized json string.</returns>
    public static string SerializeRequest(Request request)
    {
        object?[] array = [
            Request.MessageKind,
            request.MessageId,
            request.MessageType,
            request.Payload
        ];

        return JsonSerializer.Serialize(array, jsonSerializerOptions);
    }
}
