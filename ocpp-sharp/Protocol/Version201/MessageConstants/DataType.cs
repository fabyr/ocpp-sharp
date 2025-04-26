using System.Text.Json.Serialization;

namespace OcppSharp.Protocol.Version201.MessageConstants;

public static class DataType
{
    [JsonConverter(typeof(OcppEnumJsonConverter))]
    [OcppEnum]
    public enum Enum
    {
        [StringValue(DataType.@string)]
        @string,

        [StringValue(DataType.@decimal)]
        @decimal,

        [StringValue(DataType.integer)]
        integer,

        [StringValue(DataType.dateTime)]
        dateTime,

        [StringValue(DataType.boolean)]
        boolean,

        [StringValue(DataType.OptionList)]
        OptionList,

        [StringValue(DataType.SequenceList)]
        SequenceList,

        [StringValue(DataType.MemberList)]
        MemberList,
    }

    public const string @string = "string";
    public const string @decimal = "decimal";
    public const string integer = "integer";
    public const string dateTime = "dateTime";
    public const string boolean = "boolean";
    public const string OptionList = "OptionList";
    public const string SequenceList = "SequenceList";
    public const string MemberList = "MemberList";
}
