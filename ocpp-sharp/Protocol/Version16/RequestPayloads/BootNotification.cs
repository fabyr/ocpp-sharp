using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "BootNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class BootNotificationRequest : RequestPayload
{
    [JsonProperty("chargeBoxSerialNumber")]
    public CiString? ChargeBoxSerialNumber { get; set; }

    [JsonProperty("chargePointModel")]
    public CiString ChargePointModel { get; set; } = string.Empty;

    [JsonProperty("chargePointSerialNumber")]
    public CiString? ChargePointSerialNumber { get; set; }

    [JsonProperty("chargePointVendor")]
    public CiString ChargePointVendor { get; set; } = string.Empty;

    [JsonProperty("firmwareVersion")]
    public CiString? FirmwareVersion { get; set; }

    [JsonProperty("iccid")]
    public CiString? Iccid { get; set; }

    [JsonProperty("imsi")]
    public CiString? Imsi { get; set; }

    [JsonProperty("meterSerialNumber")]
    public CiString? MeterSerialNumber { get; set; }

    [JsonProperty("meterType")]
    public CiString? MeterType { get; set; }
}
