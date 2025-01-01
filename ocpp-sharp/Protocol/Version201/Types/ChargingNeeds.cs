using OcppSharp.Protocol.Version201.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.Types;

public struct ChargingNeeds
{
    public static readonly ChargingNeeds Empty = new();

    [JsonProperty("requestedEnergyTransfer")]
    public EnergyTransferModeType.Enum RequestedEnergyTransfer { get; set; }

    [JsonProperty("departureTime")]
    public DateTime? DepartureTime { get; set; }

    [JsonProperty("acChargingParameters")]
    public ACChargingParameters? AcChargingParameters { get; set; }

    [JsonProperty("dcChargingParameters")]
    public DCChargingParameters? DcChargingParameters { get; set; }
}
