using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.RequestPayloads;

[OcppMessage(ProtocolVersion.OCPP16, OcppMessageAttribute.MessageType.Request, "BootNotification", OcppMessageAttribute.Direction.PointToCentral)]
public class BootNotificationRequest : RequestPayload
{
    [JsonPropertyName("chargeBoxSerialNumber")]
    public CiString? ChargeBoxSerialNumber { get; set; }

    [JsonPropertyName("chargePointModel")]
    public CiString ChargePointModel { get; set; } = string.Empty;

    [JsonPropertyName("chargePointSerialNumber")]
    public CiString? ChargePointSerialNumber { get; set; }

    [JsonPropertyName("chargePointVendor")]
    public CiString ChargePointVendor { get; set; } = string.Empty;

    [JsonPropertyName("firmwareVersion")]
    public CiString? FirmwareVersion { get; set; }

    [JsonPropertyName("iccid")]
    public CiString? Iccid { get; set; }

    [JsonPropertyName("imsi")]
    public CiString? Imsi { get; set; }

    [JsonPropertyName("meterSerialNumber")]
    public CiString? MeterSerialNumber { get; set; }

    [JsonPropertyName("meterType")]
    public CiString? MeterType { get; set; }
}
