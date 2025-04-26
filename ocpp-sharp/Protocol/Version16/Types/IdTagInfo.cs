using OcppSharp.Protocol.Version16.MessageConstants;
using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version16.Types;

public struct IdTagInfo
{
    public static readonly IdTagInfo Empty = new();

    [JsonPropertyName("expiryDate")]
    public DateTime? ExpiryDate { get; set; }

    [JsonPropertyName("parentIdTag")]
    public CiString? ParentIdTag { get; set; }

    /// <summary>
    /// Valid values in <see cref="AuthorizationStatus"/>
    /// </summary>
    [JsonPropertyName("status")]
    public AuthorizationStatus.Enum Status { get; set; }
}
