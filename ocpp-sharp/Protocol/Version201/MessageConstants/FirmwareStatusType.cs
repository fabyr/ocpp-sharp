using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class FirmwareStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(FirmwareStatusType.Downloaded)]
        Downloaded,

        [StringValue(FirmwareStatusType.DownloadFailed)]
        DownloadFailed,

        [StringValue(FirmwareStatusType.Downloading)]
        Downloading,

        [StringValue(FirmwareStatusType.DownloadScheduled)]
        DownloadScheduled,

        [StringValue(FirmwareStatusType.DownloadPaused)]
        DownloadPaused,

        [StringValue(FirmwareStatusType.Idle)]
        Idle,

        [StringValue(FirmwareStatusType.InstallationFailed)]
        InstallationFailed,

        [StringValue(FirmwareStatusType.Installing)]
        Installing,

        [StringValue(FirmwareStatusType.Installed)]
        Installed,

        [StringValue(FirmwareStatusType.InstallRebooting)]
        InstallRebooting,

        [StringValue(FirmwareStatusType.InstallScheduled)]
        InstallScheduled,

        [StringValue(FirmwareStatusType.InstallVerificationFailed)]
        InstallVerificationFailed,

        [StringValue(FirmwareStatusType.InvalidSignature)]
        InvalidSignature,

        [StringValue(FirmwareStatusType.SignatureVerified)]
        SignatureVerified
    }

    public const string Downloaded = "Downloaded";
    public const string DownloadFailed = "DownloadFailed";
    public const string Downloading = "Downloading";
    public const string DownloadScheduled = "DownloadScheduled";
    public const string DownloadPaused = "DownloadPaused";
    public const string Idle = "Idle";
    public const string InstallationFailed = "InstallationFailed";
    public const string Installing = "Installing";
    public const string Installed = "Installed";
    public const string InstallRebooting = "InstallRebooting";
    public const string InstallScheduled = "InstallScheduled";
    public const string InstallVerificationFailed = "InstallVerificationFailed";
    public const string InvalidSignature = "InvalidSignature";
    public const string SignatureVerified = "SignatureVerified";
}
