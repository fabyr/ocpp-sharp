using System.Text.Json.Serialization;

namespace OcppSharp.Protocol;

public abstract class ResponsePayload
{
    // Responses for requests initiated by this system are handled wherever the caller is calling from.
    // See SendRequestAsync in OcppSharpServer.cs
    [JsonIgnore]
    public Response? FullResponse { get; set; }
}
