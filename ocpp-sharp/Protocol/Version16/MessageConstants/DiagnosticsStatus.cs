using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.MessageConstants;

public static class DiagnosticsStatus
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(DiagnosticsStatus.Idle)]
        Idle,

        [StringValue(DiagnosticsStatus.Uploaded)]
        Uploaded,

        [StringValue(DiagnosticsStatus.UploadFailed)]
        UploadFailed,

        [StringValue(DiagnosticsStatus.Uploading)]
        Uploading
    }

    public const string Idle = "Idle";
    public const string Uploaded = "Uploaded";
    public const string UploadFailed = "UploadFailed";
    public const string Uploading = "Uploading";
}
