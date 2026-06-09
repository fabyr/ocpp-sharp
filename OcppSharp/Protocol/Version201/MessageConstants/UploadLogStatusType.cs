using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class UploadLogStatusType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(UploadLogStatusType.BadMessage)]
        BadMessage,

        [StringValue(UploadLogStatusType.Idle)]
        Idle,

        [StringValue(UploadLogStatusType.NotSupportedOperation)]
        NotSupportedOperation,

        [StringValue(UploadLogStatusType.PermissionDenied)]
        PermissionDenied,

        [StringValue(UploadLogStatusType.Uploaded)]
        Uploaded,

        [StringValue(UploadLogStatusType.UploadFailure)]
        UploadFailure,

        [StringValue(UploadLogStatusType.Uploading)]
        Uploading,

        [StringValue(UploadLogStatusType.AcceptedCanceled)]
        AcceptedCanceled
    }

    public const string BadMessage = "BadMessage";
    public const string Idle = "Idle";
    public const string NotSupportedOperation = "NotSupportedOperation";
    public const string PermissionDenied = "PermissionDenied";
    public const string Uploaded = "Uploaded";
    public const string UploadFailure = "UploadFailure";
    public const string Uploading = "Uploading";
    public const string AcceptedCanceled = "AcceptedCanceled";
}
