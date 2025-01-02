using System.Reflection;

namespace OcppSharp.Protocol;

[AttributeUsage(AttributeTargets.Field)]
public class StringValueAttribute : Attribute
{
    public string Text { get; }

    public StringValueAttribute(string text)
    {
        Text = text;
    }
}

[AttributeUsage(AttributeTargets.Enum)]
public class OcppEnumAttribute : Attribute
{
    public OcppEnumAttribute()
    {
    }
}

[AttributeUsage(AttributeTargets.Class)]
public class OcppMessageAttribute : Attribute
{
    public enum Direction
    {
        CentralToPoint,
        PointToCentral
    }

    public enum MessageType
    {
        Request,
        Response
    }

    public Direction Dir { get; }
    public MessageType MsgType { get; }
    public string Name { get; }

    public ProtocolVersion Version { get; }

    public OcppMessageAttribute(ProtocolVersion ver, MessageType messageType, string name, Direction direction)
    {
        Version = ver;
        MsgType = messageType;
        Dir = direction;
        Name = name;
    }

    public static string? GetMessageIdentifier<T>() => GetMessageIdentifier(typeof(T));

    public static string? GetMessageIdentifier(Type t)
    {
        return t.GetCustomAttribute<OcppMessageAttribute>()?.Name;
    }
}

[AttributeUsage(AttributeTargets.Field)]
public class ValueRangeAttribute : Attribute
{
    public long Min { get; }
    public long Max { get; }

    public ValueRangeAttribute(long min, long max)
    {
        Min = min;
        Max = max;
    }
}

[AttributeUsage(AttributeTargets.Field)]
public class ValueListAttribute : Attribute // CSL: Comma Seperated List
{                                           // Value,Value,Value
    public ValueListAttribute()
    {
    }
}

// Should only be compatible with ValueListAttribute
[AttributeUsage(AttributeTargets.Field)]
public class ValueIndexedAttribute : Attribute // 0.Value,1.Value,2.Value
{
    public ValueIndexedAttribute()
    {
    }
}

[AttributeUsage(AttributeTargets.Field)]
public class ValueUnitAttribute : Attribute
{
    public string Unit { get; }

    public ValueUnitAttribute(string unit)
    {
        Unit = unit;
    }
}

[AttributeUsage(AttributeTargets.Field)]
public class ValidValuesAttribute : Attribute
{
    public Type ValidType { get; }

    public ValidValuesAttribute(Type type)
    {
        ValidType = type;
    }
}
