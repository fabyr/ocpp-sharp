using System;

namespace OcppSharp.Protocol.Version16.MessageConstants
{
    public static class FirmwareStatus
    {
        [Newtonsoft.Json.JsonConverter(typeof(OcppEnumJsonConverter))]
		[OcppEnum]
        public enum Enum
        {
            [StringValue(FirmwareStatus.Downloaded)]
            Downloaded,
            [StringValue(FirmwareStatus.DownloadFailed)]
            DownloadFailed,
            [StringValue(FirmwareStatus.Downloading)]
            Downloading,
            [StringValue(FirmwareStatus.Idle)]
            Idle,
            [StringValue(FirmwareStatus.InstallationFailed)]
            InstallationFailed,
            [StringValue(FirmwareStatus.Installing)]
            Installing,
            [StringValue(FirmwareStatus.Installed)]
            Installed
        }
        public const string Downloaded = "Downloaded";
        public const string DownloadFailed = "DownloadFailed";
        public const string Downloading = "Downloading";
        public const string Idle = "Idle";
        public const string InstallationFailed = "InstallationFailed";
        public const string Installing = "Installing";
        public const string Installed = "Installed";
    }
}