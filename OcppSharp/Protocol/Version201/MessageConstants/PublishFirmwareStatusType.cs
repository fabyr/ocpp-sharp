using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class PublishFirmwareStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(PublishFirmwareStatusType.Idle)]
        Idle,

        [StringValue(PublishFirmwareStatusType.DownloadScheduled)]
        DownloadScheduled,

        [StringValue(PublishFirmwareStatusType.Downloading)]
        Downloading,

        [StringValue(PublishFirmwareStatusType.Downloaded)]
        Downloaded,

        [StringValue(PublishFirmwareStatusType.Published)]
        Published,

        [StringValue(PublishFirmwareStatusType.DownloadFailed)]
        DownloadFailed,

        [StringValue(PublishFirmwareStatusType.DownloadPaused)]
        DownloadPaused,

        [StringValue(PublishFirmwareStatusType.InvalidChecksum)]
        InvalidChecksum,

        [StringValue(PublishFirmwareStatusType.ChecksumVerified)]
        ChecksumVerified,

        [StringValue(PublishFirmwareStatusType.PublishFailed)]
        PublishFailed
    }

    public const string Idle = "Idle";
    public const string DownloadScheduled = "DownloadScheduled";
    public const string Downloading = "Downloading";
    public const string Downloaded = "Downloaded";
    public const string Published = "Published";
    public const string DownloadFailed = "DownloadFailed";
    public const string DownloadPaused = "DownloadPaused";
    public const string InvalidChecksum = "InvalidChecksum";
    public const string ChecksumVerified = "ChecksumVerified";
    public const string PublishFailed = "PublishFailed";
}
