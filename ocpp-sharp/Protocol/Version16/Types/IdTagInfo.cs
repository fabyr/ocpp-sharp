using OcppSharp.Protocol.Version16.MessageConstants;
using Newtonsoft.Json;

namespace OcppSharp.Protocol.Version16.Types;

public struct IdTagInfo
{
    public static readonly IdTagInfo Empty = new();

    [JsonProperty("expiryDate")]
    public DateTime? ExpiryDate { get; set; }

    [JsonProperty("parentIdTag")]
    public CiString? ParentIdTag { get; set; }

    /// <summary>
    /// Valid values in <see cref="AuthorizationStatus"/>
    /// </summary>
    [JsonProperty("status")]
    public AuthorizationStatus.Enum Status { get; set; }
}
