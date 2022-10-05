using System;

namespace OcppSharp.Protocol
{
    public class StringValueAttribute : Attribute
    {
        public string Text { get; }

        public StringValueAttribute(string text)
        {
            this.Text = text;
        }
    }

    public class OcppEnumAttribute : Attribute
    {
        public OcppEnumAttribute()
        {
            
        }
    }

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

        public bool AddToMap { get; }
        public ProtocolVersion Version { get; }

        public OcppMessageAttribute(ProtocolVersion ver, MessageType messageType, string name, Direction direction, bool addToMap = false)
        {
            this.Version = ver;
            this.MsgType = messageType;
            this.Dir = direction;
            this.Name = name;
            this.AddToMap = addToMap;
        }
    }

    public class ValueRangeAttribute : Attribute
    {
        public long Min { get; }
        public long Max { get; }

        public ValueRangeAttribute(long min, long max)
        {
            this.Min = min;
            this.Max = max;
        }
    }

    public class ValueListAttribute : Attribute // CSL: Comma Seperated List
    {                                           // Value,Value,Value
        public ValueListAttribute()
        {

        }
    }

    // Should only be compatible with ValueListAttribute
    public class ValueIndexedAttribute : Attribute // 0.Value,1.Value,2.Value
    {
        public ValueIndexedAttribute()
        {

        }
    }

    public class ValueUnitAttribute : Attribute
    {
        public string Unit { get; }

        public ValueUnitAttribute(string unit)
        {
            this.Unit = unit;
        }
    }

    public class ValidValuesAttribute : Attribute
    {
        public Type ValidType { get; }

        public ValidValuesAttribute(Type type)
        {
            this.ValidType = type;
        }
    }
}