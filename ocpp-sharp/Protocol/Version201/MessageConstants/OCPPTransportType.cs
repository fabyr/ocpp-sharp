using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class OCPPTransportType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(OCPPTransportType.JSON)]
        JSON,

        [StringValue(OCPPTransportType.SOAP)]
        SOAP
    }

    public const string JSON = "JSON";
    public const string SOAP = "SOAP";
}
