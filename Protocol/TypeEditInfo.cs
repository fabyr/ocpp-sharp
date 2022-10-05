using System;
using System.Linq;

namespace OcppSharp.Protocol
{
    public class TypeEditInfo
    {
        public bool Arbitrary { get; set; } = true;
        public Type? ValidType { get; set; } = null;
        public long? RangeMin { get; set; } = null;
        public long? RangeMax { get; set; } = null;
        public bool IsList { get; set; } = false;
        public bool IsIndexedList { get; set; } = false;
        public bool IsRangeLimited { get; set; } = false;

        public string Unit { get; set; } = string.Empty;

        public string? StringType => ValidType?.Name;

        public Dictionary<CiString, int>? EnumValues
        {
            get
            {
                try
                {
                    if(ValidType != null && ValidType.IsAssignableTo(typeof(System.Enum)))
                    {
                        // Get All Enum Values of the EnumType, Get the StringValueAttribute for every one and use the text
                        var result = (System.Enum.GetValues(ValidType).Cast<System.Enum>())
                                            .Select(x => 
                                                 new KeyValuePair<string?, int>(x.GetAttributeOfType<StringValueAttribute>()?.Text, Convert.ToInt32(x))
                                                )
                                            .ToDictionary((x) => new CiString(x.Key ?? string.Empty), (x) => x.Value);
                        return result;
                    }
                    return null;
                } catch(Exception ex)
                {
                    return new Dictionary<CiString, int>() { {ex.ToString(), 0} };
                }
            }
        }
    }
}