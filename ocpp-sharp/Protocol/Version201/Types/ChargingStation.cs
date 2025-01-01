using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingStation
{
    public static readonly ChargingStation Empty = new();

    [JsonProperty("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonProperty("model")]
    public string Model { get; set; }

    [JsonProperty("vendorName")]
    public string VendorName { get; set; }

    [JsonProperty("firmwareVersion")]
    public string? FirmwareVersion { get; set; }

    [JsonProperty("modem")]
    public Modem? Modem { get; set; }
}
